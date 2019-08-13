using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class Email
    {
        public string Nombre { get; set; }
        public string DireccionEmail { get; set; }
        public string Description { get; set; }
        public int Avaible { get; set; }
        public int Modificated { get; set; }
        public int New { get; set; }
        public Email(string nombre,string direccion,string descripcion,int avaible)
        {
            Nombre = nombre;
            DireccionEmail = direccion;
            Description = descripcion;
            Avaible = avaible;
            Modificated = 0;
            New= 1;
        }
        public bool Equals(Email e2)
        {
            return DireccionEmail == e2.DireccionEmail;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}||{1}", this.DireccionEmail, this.Nombre);
            return sb.ToString();
        }
    }
}