using System;

namespace PatronPrototype_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiantes e1 = new Estudiantes();
            e1.Edad = 19;
            e1.Fecha_nacimiento = Convert.ToDateTime("2001-01-01");
            e1.Nombre = "Alfredo Matias";
            e1.idInfo = new IdInfo(20119);

            Estudiantes e2 = e1.copy();
            Estudiantes e3 = e1.copy();

            //mostrar los valores de e1,e2,e3
            Console.WriteLine("Valores originales de e1,e2,e3: ");
            Console.WriteLine("         valores de e1  ");
            MostrarValores(e1);
            Console.WriteLine("         valores de e2  ");
            MostrarValores(e2);
            Console.WriteLine("         valores de e3  ");
            MostrarValores(e3);
            Console.WriteLine("\n");
            //cambiando los valores de las propiedades de e1 y mostrarla
            e1.Edad = 30;
            e1.Fecha_nacimiento = Convert.ToDateTime("1989-03-02");
            e1.Nombre = "Maria Cabral";
            e1.idInfo = new IdInfo(12423);
            Console.WriteLine("los valores de e1,e2,e3 despues de modificar el e1 ");
            Console.WriteLine("         valores de e1  ");
            MostrarValores(e1);
            Console.WriteLine("         valores de e2  ");
            MostrarValores(e2);
            Console.WriteLine("         valores de e3  ");
            MostrarValores(e3);

            Console.ReadKey();
        }

        public static void MostrarValores(Estudiantes e)
        {
            Console.WriteLine(" Nombre: {0}, Edad: {1}, Fecha de Nacimiento: {2}", e.Nombre, e.Edad, e.Fecha_nacimiento);
            Console.WriteLine(" ID: {0}", e.idInfo.IdNumber);
        }
    }


}
