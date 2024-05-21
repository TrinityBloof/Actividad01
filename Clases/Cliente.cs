using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Clases
{
    internal class Cliente : Persona
    {
        public int Telefono { get; set; }
        public required Empresa Empresa { get; set; }

        public Cliente() { }

        public string DetalleCliente()
        {
            return $"{DetallePersona()}, Teléfono: {Telefono}, Empresa: {Empresa?.Nombre}";
        }
    }
}
