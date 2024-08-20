using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            persona.Nombres = "Harold";
            persona.Apellidos = "Medrano";

            persona.AsignarNombresCompletos();

            Console.WriteLine("El nombre completo es: " + persona.NombresCompletos);
            Console.Read();
        }
    }
}
