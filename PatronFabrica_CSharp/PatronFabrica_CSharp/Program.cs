using System;

namespace PatronFabrica_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificacionFabrica fabrica = new NotificacionFabrica();

            INotificacion n1 = fabrica.getNotificacion("Whatsapp");
            n1.Recibido();
            n1.No_Recibido();
            Console.WriteLine("");
            INotificacion n2 = fabrica.getNotificacion("Instagram");
            n2.Recibido();
            n2.No_Recibido();
            Console.WriteLine("");
            INotificacion n3 = fabrica.getNotificacion("Facebook");
            n3.Recibido();
            n3.No_Recibido();
            Console.WriteLine("");
            INotificacion n4 = fabrica.getNotificacion(" ");
            n4.Recibido();
            n4.No_Recibido();

            Console.ReadKey();
        }
    }
}
