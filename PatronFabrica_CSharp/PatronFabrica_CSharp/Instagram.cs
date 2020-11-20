using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica_CSharp
{
    public class Instagram: INotificacion
    {
        private string Usuario;
        private string Password;
        private string Nickname;

        public Instagram()
        {
            this.Usuario = "EDDY123";
            this.Password = "1234";
            this.Nickname = "Eddy";
        }

        public void Recibido()
        {
            Console.WriteLine("Has recibido una notificacion en Instagram");
        }


        public void No_Recibido()
        {
            Console.WriteLine("No has recibido ninguna notificacion en Instagram");
        }
    }
}
