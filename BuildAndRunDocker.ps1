docker build -t underwriting-image -f Dockerfile .
docker run -p 80:80 -p 443:443 `
-e ClientCredentials__ClientId='42OzZOapKeNrUalFppvoFZzDPS5ZPHGqbGsZlC4hxBOE9mv6' `
-e ClientCredentials__ClientSecret='Kcu5tea5gNk2MzlITsp14xpXZdtG7kj7P4TaFWEaTdIjblKg' `
-e ConnectionStrings__DefaultConnection='Server=enterprise-dev.cykwtf0wyekw.us-east-1.rds.amazonaws.com;Database=Artefacts_Underwriting;user id=ent_underwriting;password=PC2tX7sEHGwwKU3Q!;Encrypt=False' `
-e PluginBaseURL='https://dev-api.i3verticals.com' `
-e PluginUrl='https://dev-content.i3verticals.com/uapi/plugins/007c40c5fc/dev/i3plugins.js?psid=' `
underwriting-image