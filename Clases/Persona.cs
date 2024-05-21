using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Clases
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public Sexo Sexo { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, Sexo sexo, int edad)
        {
            Nombre = nombre;
            Sexo = sexo;
            Edad = edad;
        }

        public Persona() {
        
        }
        public string DetallePersona()
        {
            return $"Nombre: {Nombre}, Sexo: {Sexo}, Edad: {Edad}";
        }
    }
}
