using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EnvioMails
{
    public class Mail : MailMessage
    {
        public static Dato Dato { get; set; }
        public string Destino { get; set; }
        public bool Enviado { get; set; }
        public string Motivo { get; set; }

        public Mail(Dato dato, string destino) : this(destino)
        {
            Dato = dato;
            this.From = new MailAddress(Dato.Origen);
            this.Subject = Dato.Asunto;
            this.Body = Dato.Cuerpo;
        }
        private Mail(string destino)
        {
            this.To.Add(new MailAddress(destino));
            this.Destino = destino;
            this.Enviado = false;
            this.Motivo = string.Empty;
        }

        public static bool ValidarMail(string mail)
        {
            try
            {
                var addr = new MailAddress(mail);
                return addr.Address == mail;
            }
            catch
            {
                return false;
            }
        }
    }
}
