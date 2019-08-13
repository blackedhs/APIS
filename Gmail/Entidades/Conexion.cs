using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conexion
    {
        public string User { get; set; }
        public string Pass { get; set; }
        public int Port { get; set; }
        public string Host { get; set; }

        public Conexion(string user, string pass,int port,string host)
        {
            User = user;
            Pass = pass;
            Port = port;
            Host = host;
        }
        public bool Conectar(string to,string subjet, string body)
        {
            SmtpClient smtp = new SmtpClient(Host, Port);
            NetworkCredential cert = new NetworkCredential(User, Pass);
            smtp.Credentials = cert;
            smtp.EnableSsl = true;

            MailMessage mail = new MailMessage(User, to, subjet, body);
            try
            {
                smtp.Send(mail);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
