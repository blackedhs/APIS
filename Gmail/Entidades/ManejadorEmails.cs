using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ManejadorEmails
    {
       
        public List<Email> Emails { get; set; }
        public int Cant { get; set; }
        public ManejadorEmails()
        {
            Emails = new List<Email>();
            Cant = 0;
        }
        public static bool operator +(ManejadorEmails manejador,Email email)
        {
            foreach (Email e in manejador.Emails)
            {
                if (email.Equals(e))
                    return false;
            }
            manejador.Emails.Add(email);
            manejador.Cant++;
            return true;
        }
        public static bool operator -(ManejadorEmails manejador, Email email)
        {
            foreach (Email e in manejador.Emails)
            {
                if (email.Equals(e))
                {
                    email.Avaible = 0;
                    manejador.Cant--;
                    return true;
                }                    
            }           
            return false;
        }
    }
}
