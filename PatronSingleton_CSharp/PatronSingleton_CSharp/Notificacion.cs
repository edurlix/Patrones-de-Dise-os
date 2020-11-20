using System;
using System.Collections.Generic;
using System.Text;

namespace PatronSingleton_CSharp
{
    public class Notificacion
    {

        private static Notificacion mensaje;


        private Notificacion()
        {

        }

        public static Notificacion GetNotificacion()
        {
            if (mensaje == null)
            {
                mensaje = new Notificacion();
            }
            return mensaje;
        }


        public void recibir_notificacion()
        {
            Console.WriteLine("Haz recibido un mensaje");
        }

        public void no_recibir()
        {
            Console.WriteLine("no haz recibido ningun mensaje");
        }
    }
}
