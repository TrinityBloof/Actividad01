using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Clases
{
    internal class Jefe : Empleado
    {
        public string Categoria { get; set; }

        public Jefe() { }

        public string MostrarJefe()
        {
            return $"{DetallePersona()}, Categoría: {Categoria}, Salario: {Salario}, Empresa: {Empresa.Nombre}, Jefatura: {Jefatura}";
        }
    }
}
