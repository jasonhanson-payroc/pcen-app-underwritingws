using Azure.Identity;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Microsoft.Graph.Users.Item.SendMail;
using Underwriting.Data;

namespace Underwriting.EmailSender
{
    public class EmailSender
    {

        private string? MailFrom;
        private string? EmailDisplayName;
        private string? TenantId;
        private string? ClientId;
        private string? ClientSecret;

        public EmailSender(IConfiguration configuration)
        {

            MailFrom = configuration.GetValue<string>("UnderwritingEmailFrom");
            EmailDisplayName = configuration.GetValue<string>("EmailDisplayName");
            TenantId = configuration.GetValue<string>("TenantId");
            ClientId = configuration.GetValue<string>("ClientId");
            ClientSecret = configuration.GetValue<string>("ClientSecret");
        }

        public void SendForgotPasswordLink(ApplicationUser _user, string CallbackUrl)
        {
            string mailSubject = "i3 Underwriting Password Reset";
            string emailBody = @"Hello "+ _user.DisplayName + ",<br><br>We have received a request to reset your password. If you made this request, you can reset your password and log in by clicking the link below. <br><br>";
            emailBody += "<a href="+ CallbackUrl + "  target='_blank' style='background-color: #22BC66;border: 8px solid #22BC66;color: #fff;border-radius: 3px; padding: 1px;'>Reset your password</a><br><br>";
            emailBody += "If you didn't request this password reset, [please inform IT of a possible security breach](mailto: itsupport@i3verticals.com). <br><br>";
            emailBody += "Thanks,<br>i3 ERP Development Team";
            SendEmailAsync(emailBody, _user.Email, mailSubject);
        }

        public void SendUserCreationSuccessMail(ApplicationUser _user,string CallbackUrl)
        {
            string mailSubject = "i3 Underwriting - Account Has Been Successfully Created!";
            string emailBody = @"Hello "+ _user.DisplayName + ",<br><br>Welcome to i3 Underwriting!.<br>The email address has been successfully created. Kindly click the following link to update your password.<br><br>";
            emailBody += "<b>Email<b> :  "+ _user.Email + "<br><br>";
            emailBody += "<b>Password<b> : <a href=" + CallbackUrl + "  target='_blank' style='background-color: #22BC66;border: 8px solid #22BC66;color: #eee;border-radius: 3px; padding: 1px;'>Update your password</a><br><br>";
            emailBody += "Thanks,<br>i3 ERP Development Team";
            SendEmailAsync(emailBody, _user.Email, mailSubject);
        }
        public async void SendEmailAsync(string mailBody, string mailTo, string mailSubject, Dictionary<string, byte[]>? fileBytesWithFileNames = null)
        {
            string mailFrom = MailFrom;
            string fromName = EmailDisplayName;
            string to = mailTo;// AddNoteIdInEmail(mailTo, noteId.Value);
            string EmailIsoSupport = "";

            var scopes = new[] { "https://graph.microsoft.com/.default" };

            var options = new ClientSecretCredentialOptions
            {
                AuthorityHost = AzureAuthorityHosts.AzurePublicCloud,
            };

            // https://learn.microsoft.com/dotnet/api/azure.identity.clientsecretcredential
            var clientSecretCredential = new ClientSecretCredential(
                TenantId, ClientId, ClientSecret, options);

            var graphClient = new GraphServiceClient(clientSecretCredential, scopes);

            var requestBody = new SendMailPostRequestBody
            {
                Message = new Microsoft.Graph.Models.Message
                {
                    Subject = mailSubject,
                    Body = new ItemBody
                    {
                        ContentType = BodyType.Html,
                        Content = mailBody,
                    },
                    ToRecipients = new List<Recipient>
                    {
                        new Recipient
                        {
                            EmailAddress = new Microsoft.Graph.Models.EmailAddress
                            {
                                Address = to,
                            },
                        },
                    },
                    ReplyTo = new List<Recipient>
                    {
                        new Recipient
                        {
                            EmailAddress = new Microsoft.Graph.Models.EmailAddress
                            {
                                Address =mailFrom,
                                Name = fromName,
                            },
                        },
                    },
                    CcRecipients = new List<Recipient>(),
                    From = new Recipient
                    {
                        EmailAddress = new Microsoft.Graph.Models.EmailAddress
                        {
                            Address = mailFrom,
                            Name = fromName,
                        },
                    }
                },
                SaveToSentItems = false,
            };

            foreach (var address in EmailIsoSupport.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
            {
                requestBody.Message.CcRecipients.Add(new Recipient() { EmailAddress = new Microsoft.Graph.Models.EmailAddress() { Address = address } });
            }

            if (fileBytesWithFileNames != null && fileBytesWithFileNames.Any())
            {
                requestBody.Message.HasAttachments = true;
                requestBody.Message.Attachments = new List<Microsoft.Graph.Models.Attachment>();

                Microsoft.Graph.Models.FileAttachment attachment;
                foreach (var fileBytes in fileBytesWithFileNames)
                {
                    attachment = new Microsoft.Graph.Models.FileAttachment()
                    {
                        ContentBytes = fileBytes.Value,
                        Name = fileBytes.Key,
                    };

                    requestBody.Message.Attachments.Add(attachment);
                }
            }

            await graphClient.Users[mailFrom].SendMail.PostAsync(requestBody);
        }


    }
}
