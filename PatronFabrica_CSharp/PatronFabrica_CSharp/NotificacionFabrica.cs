using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica_CSharp
{
    public class NotificacionFabrica
    {
        public INotificacion getNotificacion(string Notificacion)
        {
            if(Notificacion == null)
            {
                return new Ninguno();
            }
            else if (Notificacion.Equals("Whatsapp"))
            {
                return new Whatsapp();
            }
            else if (Notificacion.Equals("Instagram"))
            {
                return new Instagram();
            }
            else if (Notificacion.Equals("Facebook"))
            {
                return new Facebook();
            }

            return new Ninguno();
        }
    }
}
