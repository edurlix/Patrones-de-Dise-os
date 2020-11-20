using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica_CSharp
{
    public class Facebook: INotificacion
    {
        private string Usuario;
        private string Password;
        private string Nickname;

        public Facebook()
        {
            this.Usuario = "Seba13";
            this.Password = "1234";
            this.Nickname = "Sebastian";
        }

        public void Recibido()
        {
            Console.WriteLine("Has recibido una notificacion en Facebook");
        }


        public void No_Recibido()
        {
            Console.WriteLine("No has recibido ninguna notificacion en Facebook");
        }
    }
}
