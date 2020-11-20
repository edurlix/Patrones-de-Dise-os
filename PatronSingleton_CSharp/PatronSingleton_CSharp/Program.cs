using System;

namespace PatronSingleton_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Notificacion n = Notificacion.GetNotificacion();
            n.recibir_notificacion();
            n.no_recibir();

            bool verificacion = n is Notificacion;
            Console.WriteLine(verificacion);

            Console.ReadKey();
        }
    }
}
