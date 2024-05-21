using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Clases
{
    internal class Empleado : Persona
    {

        public double Salario { get; set; }
        public required Empresa Empresa { get; set; }
        public Jefe Jefatura { get; set; }

        public Empleado() { }

        public double CalcularSalario()
        {
            return Salario;
        }
    }
}
