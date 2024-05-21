using Actividad01.Clases;

namespace Actividad01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Bob", Sexo.Hombre, 30);
            Console.WriteLine($"Datos de una persona: {persona1.DetallePersona()}");

            Empresa empresa = new Empresa { Nombre = "Tech Corp" };
            Console.WriteLine($"Nombre de la empresa: {empresa.Nombre}");

            Jefe jefe = new Jefe
            {
                Nombre = "Alice",
                Sexo = Sexo.Mujer,
                Edad = 40,
                Salario = 15000,
                Empresa = empresa,
                Jefatura = null,
                Categoria = "Senior Manager"
            };
            Console.WriteLine($"Datos del jefe: {jefe.MostrarJefe()}");

            Empleado empleado = new Empleado
            {
                Nombre = "Bob",
                Sexo = Sexo.Hombre,
                Edad = 30,
                Salario = 13000,
                Empresa = empresa,
                Jefatura = jefe
            };
            Console.WriteLine($"Datos del empleado: {empleado.DetallePersona()}, Salario: {empleado.Salario}, Empresa: {empresa.Nombre}, Jefatura: {jefe.Nombre}");
            Console.WriteLine($"Salario de {empleado.Nombre}: {empleado.CalcularSalario()}");

            Cliente cliente = new Cliente
            {
                Nombre = "Alice",
                Sexo = Sexo.Mujer,
                Edad = 28,
                Telefono = 123456789,
                Empresa = empresa
            };
            Console.WriteLine($"Datos del cliente: {cliente.DetalleCliente()}");
        }
    }
}
