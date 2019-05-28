using System;

namespace EnvioMails
{
    public class Dato
    {
        public string Remitente;
        public string Password;
        public string Asunto;
        public string Cuerpo;
        public Object Adjunto;

        public Dato(string origen, string clave, string asunto, string cuerpo, Object adjunto)
        {
            this.Remitente = origen;
            this.Password = clave;
            this.Asunto = asunto;
            this.Cuerpo = cuerpo;
            this.Adjunto = adjunto;
        }

    }
}
