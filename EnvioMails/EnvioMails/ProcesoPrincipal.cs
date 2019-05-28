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
using System.Threading;

namespace EnvioMails
{
    public class ProcesoPrincipal
    {
        // Singleton.
        private static ProcesoPrincipal _instance;
        public static ProcesoPrincipal Instancia { get => _instance; }
        static ProcesoPrincipal() => _instance = new ProcesoPrincipal();

        // Fields
        internal ProcesoMensaje ProcesoMensaje { get => procesoMensaje; }
        private ProcesoMensaje procesoMensaje;

        private const int TIEMPO_ESPERA_SEGUNDOS = 15;

        static System.Threading.Timer timer = new System.Threading.Timer(comenzarEnvio);

        private static void comenzarEnvio(object state)
        {
            try
            {
                EmailHelper.SendMail();
                timer.Dispose();
                
            }
            catch (Exception)
            {
                // LOGGGER --> 
            }
            finally
            {
                if (timer != null)
                    timer.Change(TimeSpan.FromSeconds(TIEMPO_ESPERA_SEGUNDOS), TimeSpan.Zero);
            }
        }

        public void Comenzar(Dato dato)
        {
            this.procesoMensaje = new ProcesoMensaje()
            {
                Asunto = dato.Asunto,
                CuerpoMensaje = dato.Cuerpo,
                Password = dato.Password,
                Remitente = dato.Remitente
            };

            timer.Change(TimeSpan.Zero, TimeSpan.Zero);
        }

    }
}
