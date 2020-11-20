using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica_CSharp
{
    public class Ninguno: INotificacion
    {
        
        public void Recibido()
        {
            Console.WriteLine("NO ESPECIFICO APLICACION");
        }


        public void No_Recibido()
        {
            Console.WriteLine("NO ESPECIFICO APLICACION");
        }
    }
}
