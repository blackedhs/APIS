using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvioMails
{
    class ProcesoMensaje
    {
        public const string ApiKey = "<API_KEY_HASH";

        public Queue<Destinatario> Destinarios { get; set; } = new Queue<Destinatario>();
        public string Remitente { get; set; }
        public string Asunto { get; set; }
        public string CuerpoMensaje { get; set; }
        private string Adjunto { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// Encargado de cargar los dest.
        /// </summary>
        public void CargarDestinatarios()
        {

        }

        /// <summary>
        /// Almacena el estado del proceso.
        /// </summary>
        public void AlmacenarEstadoProceso()
        {

        }

        /// <summary>
        /// Obtener ultimos estados.
        /// </summary>
        public void ObtenerUltimoEstadoAlmacenado()
        {

        }
    }
}
