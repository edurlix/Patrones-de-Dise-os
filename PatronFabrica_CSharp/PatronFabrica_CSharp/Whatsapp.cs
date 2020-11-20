using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica_CSharp
{
    public class Whatsapp:INotificacion
    {
        private string Name;
        private string Phone_Number;

        public Whatsapp()
        {
            this.Name = "Franklin";
            this.Phone_Number = "809-333-7924";
        }

        public void Recibido()
        {
            Console.WriteLine("Has recibido una notificacion en Whatsapp");
        }


        public void No_Recibido()
        {
            Console.WriteLine("No has recibido ninguna notificacion en Whatsapp");
        }

        
    }
}
