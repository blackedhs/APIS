using System;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnvioMails
{
    public static class EmailHelper
    {
        private const string CLIENT_ID = "63662581694-p9m24hbnn5kfu30ptrtvbul5n9mhbl3q.apps.googleusercontent.com";

        private const string CLIENT_SECRET = "w85y4O-omg3khldecWyuqBGI";
    
        static string[] Scopes = { GmailService.Scope.GmailReadonly, GmailService.Scope.GmailSend };
        static string ApplicationName = "Gmail API .NET Quickstart";

        public static bool SendMail()
        {
            try
            {
                // Operaciones
                UserCredential credential;

                using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                }

                // Creamos un servicio de GMAIL.
                var service = new GmailService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                // Definimos parametros de la solicitud.
                UsersResource.LabelsResource.ListRequest request = service.Users.Labels.List("me");

                //UsersResource.LabelsResource.ListRequest request = 
                string plainText = "To: mvallejo@nosis.com\r\n" +
                               "Subject: subject Test\r\n" +
                               "Content-Type: text/html; charset=us-ascii\r\n\r\n" +
                               "<h1>Body Test </h1>";

                var newMsg = new Google.Apis.Gmail.v1.Data.Message();
                newMsg.Raw = EmailHelper.Base64UrlEncode(plainText.ToString());
                service.Users.Messages.Send(newMsg, "me").Execute();
                
                // ??
                //IList<Label> labels = request.Execute().Labels;

                //if (labels != null && labels.Count > 0)
                //{
                //    foreach (var labelItem in labels)
                //        File.AppendAllText("salidaLabels.txt", labelItem.Name);
                //}
                //else
                //{
                //    throw new ApplicationException("No labels found.");
                //}


                return true;
            }
            catch (Exception ex)
            {
                // LOGGER
                return false;
            }
        }

        public static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }
    }
}
