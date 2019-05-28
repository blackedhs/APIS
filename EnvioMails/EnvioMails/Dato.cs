using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EnvioMails
{
    public class Dato
    {
        public string Origen;
        public string Clave;
        public string Asunto;
        public string Cuerpo;
        public Object Adjunto;

        public Dato(string origen, string clave, string asunto, string cuerpo, Object adjunto)
        {
            this.Origen = origen;
            this.Clave = clave;
            this.Asunto = asunto;
            this.Cuerpo = cuerpo;
            this.Adjunto = adjunto;
        }

    }
}
