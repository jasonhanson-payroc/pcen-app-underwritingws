const child_process = require('child_process');
const fs = require('fs');

// Inspired by, but legally distinct from:
//   https://github.com/justmiles/ecs-deploy/blob/master/src/deployer/deployer.go
//
// Changes:
//   - Service name is not implied by vague "environment" and "stack" parameters. Instead,
//     you pass the ECS service name in directly.
//   - Output parameter is more clear about where it comes from. The version parameter is
//     now: `/ecs-deploy/$serviceName/deployed-tag`.

/**
 * Finds AWS CLI in your $PATH. Relies on `which`.
 * @returns {string} Absolute path to the AWS CLI.
 */
function findAwsCli() {
  if (!('r' in findAwsCli)) {
    const output = child_process.execSync("which aws")
    const result = output.toString().trim()
    if (result.length < 1) {
      throw new Error("AWS CLI is not installed. See: https://docs.aws.amazon.com/cli/latest/userguide/getting-started-install.html")
    }
    findAwsCli.r = result
  }
  return findAwsCli.r
}

/**
 * @param {string} cmd
 * @returns {object}
 */
function awsCli(cmd) {
  console.log('awsCli >>>')
  console.log(`${findAwsCli()} --output=json ${cmd}`)
  const output = child_process.execSync(`${findAwsCli()} --output=json ${cmd}`).toString().trim()
  console.log(output)
  const result = JSON.parse(output)
  console.log('<<< awsCli')
  if (typeof result !== "object") {
    throw new Error("Invalid output from AWS CLI")
  }
  return result
}

/**
 * Returns the current AWS region.
 * @returns {string}
 */
function awsRegion() {
  if (process.env.AWS_DEFAULT_REGION) {
    return process.env.AWS_DEFAULT_REGION
  }

  const output = child_process.execSync(`${findAwsCli()} configure get region`)
  return output.toString().trim()
}

/**
 * Returns the current AWS account ID.
 * @returns {string}
 */
function awsAccountId() {
  const output = child_process.execSync(`${findAwsCli()} --output=json sts get-caller-identity`).toString()
  const result = JSON.parse(output)
  if (typeof result !== "object") {
    throw new Error("Invalid output from AWS CLI")
  }
  return result.Account
}

/**
 * Uses the Azure Pipelines CLI to gather pipeline variables for a given group.
 * @param azDOOrg
 * @param azDOProject
 * @param groupId
 * @returns {*}
 */
function gatherPipelineGroupVariables(azDOOrg, azDOProject, groupId) {
  const output = child_process.execSync(`az pipelines variable-group variable list --organization=https://dev.azure.com/${azDOOrg} --project="${azDOProject}" --group-id ${groupId} --output json`)
  const result = JSON.parse(output.toString())

  if (typeof result !== "object") {
    throw new Error("Invalid output from AZ CLI")
  }

  return Object.keys(result).map(name => ({
    name,
    isSecret: result[name].isSecret !== null,
    value: result[name].value,
  }))
}

const [_, __, clusterAndServiceName, tag, azDOOrgAndProject, variableGroupId, ssmPrefix] = process.argv
const [clusterName, serviceName] = clusterAndServiceName.split('/')
const [azDOOrg, azDOProject] = azDOOrgAndProject.split('/')
const parameterName = `/ecs-deploy/${serviceName}/deployed-tag`
const parameterName2 = `${ssmPrefix}/ecs-deploy/${serviceName}/deployed-tag`

console.log("Example Usage:")
console.log("node ecs-deploy/index.js <service> <tag> <variable group id> <variable ssm prefix>")
console.log("# Deploys tag 11178 to schoolpay-fpm, variable group 112")
console.log("node ecs-deploy/index.js schoolpay-fpm 11178 112 /prod/schoolpay-fpm")
console.log("# Deploys tag dev to ll-api, variable group 113")
console.log("node ecs-deploy/index.js ll-api dev 113 /dev/ll")
console.log("")

console.log("Note: This tool has not been tested with private parameters. Report defects that you find.")
console.log("")

console.log(`Deploying ${tag} to ${serviceName}`)
console.log("IAM Permissions needed:")
console.log(`  "ecs:DescribeServices",`)
console.log(`  "ecs:DescribeTaskDefinition",`)
console.log(`  "ecs:ListTagsForResource",`)
console.log(`  "ecs:RegisterTaskDefinition",`)
console.log(`  "ecs:UpdateService",`)
console.log(`  "ssm:PutParameter",`)
console.log(`  "s3:PutObject",`)

console.log("")
console.log("Gathering information...")


const servicesOutput = awsCli(`ecs describe-services --cluster=${clusterName} --services=${serviceName}`)
if (servicesOutput.length > 0) {
  throw new Error(`Error locating service (${JSON.stringify(servicesOutput)})`)
}

const service = awsCli(`ecs describe-services --cluster=${clusterName} --services=${serviceName}`).services[0]
const task = awsCli(`ecs describe-task-definition --task-definition=${service.taskDefinition}`)
const region = awsRegion()
const account = awsAccountId()

// assert: ContainerDefinitions is length 1
if (task.taskDefinition.containerDefinitions.length !== 1) {
  throw new Error("Cannot use ecs-deploy on services that use multiple tasks (yet, e-mail the devops team with your use case)")
}

const container = task.taskDefinition.containerDefinitions[0]
const image = container.image.split(':')[0].concat(":",`${tag}`)
const tagResponse = awsCli(`ecs list-tags-for-resource --resource-arn=${task.taskDefinition.taskDefinitionArn}`)
const tags = tagResponse.tags.length > 0 ? tagResponse.tags : [{ key: 'deployedWith', value: 'ecs-deploy' }]

const variables = gatherPipelineGroupVariables(azDOOrg, azDOProject, variableGroupId)
const publicVars = variables.filter(x => !x.isSecret)
const privateVars = variables.filter(x => x.isSecret)

console.log("Uploading private parameters to SSM...")
for (const secret of privateVars) {
  awsCli(`ssm put-parameter --name=${ssmPrefix}/${secret.name} --value="${process.env[secret.name]}" --type=SecureString --overwrite`)
}
for (const secret of publicVars) {
  awsCli(`ssm put-parameter --name=${ssmPrefix}/${secret.name} --value="${secret.value}" --type=SecureString --overwrite`)
}
const secretMappings = variables.map(x => ({
  name: x.name,
  valueFrom: `arn:aws:ssm:${region}:${account}:parameter${ssmPrefix}/${x.name}`
}))

console.log(`Registering new task definition for ${image}...`)

const registerTaskDefinitionOutput = awsCli(`ecs register-task-definition `
  + `--family=${task.taskDefinition.family} `
  + `--container-definitions='${JSON.stringify([{ ...container, ...{ image, secrets: secretMappings, readonlyRootFilesystem: true } }])}' `
  + `--execution-role-arn=${task.taskDefinition.executionRoleArn} `
  + `--task-role-arn=${task.taskDefinition.taskRoleArn} `
  + `--network-mode=${task.taskDefinition.networkMode} `
  + `--cpu=${task.taskDefinition.cpu} `
  + `--memory=${task.taskDefinition.memory} `
  + `--volumes='${JSON.stringify(task.taskDefinition.volumes)}' `
  + `--tags='${JSON.stringify(tags)}' `
  + `--requires-compatibilities=${task.taskDefinition.requiresCompatibilities}`)

console.log(`Updating service ${serviceName}...`)

awsCli(`ecs update-service `
  + `--cluster=${service.clusterArn} `
  + `--service=${serviceName} `
  + `--desired-count=${service.desiredCount} `
  + `--task-definition=${registerTaskDefinitionOutput.taskDefinition.taskDefinitionArn} `
  + `--deployment-configuration='${JSON.stringify(service.deploymentConfiguration)}' `
  + `--force-new-deployment `
  + `--network-configuration='${JSON.stringify(service.networkConfiguration)}' `
  + `--platform-version=${service.platformVersion}`)

console.log("Waiting for ECS to enter stable state...")

let healthCounter = 0;
let isHealthy = false;
do {
  // RK: Note to future maintainers: We would like to write our own `wait services-stable` that
  // has more interactive output and a customizable delay time.
  try {
    healthCounter++;
    child_process.execSync(`${findAwsCli()} ecs wait services-stable --cluster=${clusterName} --services=${serviceName}`)
    isHealthy = true;
  } catch {
    console.warn(`Health check timed out, trying again ${healthCounter}/10`)
  }
} while (!isHealthy || healthCounter <= 10);

if (!isHealthy) {
  console.error("The deployment isn't healthy");
  process.exit(255);
}

console.log(`Writing version parameter to ${parameterName}...`)

awsCli(`ssm put-parameter --name=${parameterName} --value=${tag} --type=String --overwrite`)
awsCli(`ssm put-parameter --name=${parameterName2} --value=${tag} --type=String --overwrite`)