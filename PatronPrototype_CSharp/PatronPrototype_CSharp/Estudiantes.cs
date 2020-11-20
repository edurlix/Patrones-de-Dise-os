using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPrototype_CSharp
{
    public class Estudiantes
    {
        public int Edad;
        public DateTime Fecha_nacimiento;
        public string Nombre;
        public IdInfo idInfo;

        public Estudiantes copy()
        {
            return (Estudiantes)this.MemberwiseClone();
        }


    }
}
