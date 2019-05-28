using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnvioMails
{
    public class Proceso
    {
        public static List<string> ListaContactos { get; set; }

        static System.Threading.Timer timer = new System.Threading.Timer(hacerAlgo);

        private static void hacerAlgo(object state)
        {
            try
            {
                throw new NotImplementedException();

            }
            catch (Exception)
            {
                // tiemp ode espera en ms
                int tiempoEspera = 15000;
                timer.Change(tiempoEspera, 0);
            }
        }

        static Proceso()
        {
            timer.Change(0, 9999999);
        }

        public bool Iniciar(Dato dato)
        {
            try
            {
                CargarContactos();
                foreach (var destino in ListaContactos)
                {
                    var m = new Mail(dato, destino);

                    // Semaforo. 

                    //Semaphore semaphore = new Semaphore();

                    // DEJAME PASAR 2. 
                    //semaphore.WaitOne();
                    // TODO : Async operation.
                    //Task.Factory.StartNew(() =>
                    //{
                        Proceso.EnviarMail(m);
                    //});
                    //semaphore.Release();


                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("logs.err", ex.Message);
                throw ex;
            }
            return true;
        }
        private void CargarContactos()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Datos");
            var pathArchivo = Path.Combine(path, "Contactos.txt");
            ListaContactos = new List<string>();
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            if (!File.Exists(pathArchivo))
                throw new Exception("No existe archivo");
            using (StreamReader archivo = new StreamReader(pathArchivo))
            {
                while (!archivo.EndOfStream)
                {
                    var linea = archivo.ReadLine();
                    if (string.IsNullOrEmpty(linea))
                        continue;
                    if (Mail.ValidarMail(linea.Trim()))
                        ListaContactos.Add(linea.Trim());
                }
            }
        }

        static string[] Scopes = { GmailService.Scope.GmailReadonly };
        static string ApplicationName = "Gmail API .NET Quickstart";
        public static void EnviarMail(Mail m)
        {
            try
            {
                // Autenticación.
                UserCredential credential;

                using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    // Lee archivos de configuración.
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        // Guarda token para enviar correos. (Consultas a la api)
                        new FileDataStore(credPath, true)).Result;
                }

                // Servicio
                var service = new GmailService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                //Message message = new Message
                //{
                     
                //};

                //var msg = new AE.Net.Mail.MailMessage
                //{
                //    Subject = "Your Subject",
                //    Body = "Hello, World, from Gmail API!",
                //    From = new MailAddress("[you]@gmail.com")
                //};
                //msg.To.Add(new MailAddress("yourbuddy@gmail.com"));
                //msg.ReplyTo.Add(msg.From); // Bounces without this!!
                //var msgStr = new StringWriter();
                //msg.Save(msgStr);
                
                // Envio de correo.
                service.Users.Messages.Send(new Message
                {
                    Raw = Base64UrlEncode("cuerpo del mensaje")
                }, "me").Execute();

                //SmtpClient client = ObtenerCliente(ref m);
                //client.Send(m);
                //m.Enviado = true;
            }
            catch (Exception ex)
            {
                ex = new Exception("Contraseña inválida");
                throw ex;
            }
        }

        private static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            // Special "url-safe" base64 encode.
            return Convert.ToBase64String(inputBytes)
              .Replace('+', '-')
              .Replace('/', '_')
              .Replace("=", "");
        }

        private static SmtpClient ObtenerCliente(ref Mail m)
        {
            var EmailOrigen = Mail.Dato.Origen;
            var gmail = EmailOrigen.Contains("gmail");
            var outlook = EmailOrigen.Contains("outlook") ? true : EmailOrigen.Contains("hotmail") ? true : false;

            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.Host = gmail ? "smtp.gmail.com" : outlook ? "smtp.office365.com" : string.Empty;
            if (string.IsNullOrEmpty(client.Host))
                throw new Exception("Mail incorrecto");
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential(EmailOrigen, Mail.Dato.Clave);
            return client;
        }
    }
}
