using EnvioMails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese cuenta: ");
            var origen = Console.ReadLine();
            Console.Write("Password: ");
            var pass = Console.ReadLine();
            Console.Write("Ingrese asunto: ");
            var asunto = Console.ReadLine();
            Console.Write("Ingrese: ");
            var cuerpo =  Console.ReadLine();
            Dato dato = new Dato(origen, pass, asunto, cuerpo, cuerpo);
            Proceso proceso = new Proceso();
            proceso.Iniciar(dato);
        }
    }
}
