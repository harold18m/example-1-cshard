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
            Coordenada coordenada1 = new Coordenada
            {
                x = 10,
                y = 20,
            };

            Coordenada coordenada2 = new Coordenada
            {
                x = 10,
                y = 40,
            };

            Coordenada coordenada3 = new Coordenada
            {
                x = 20,
                y = 20,
            };

            Coordenada coordenada4 = new Coordenada
            {
                x = 20,
                y = 40,
            };

            Rectangulo rectangulo = new Rectangulo
            {
                coordenadas =
                {
                    coordenada1,coordenada2,coordenada3,coordenada4                
                }
            };

            rectangulo.calcularAltura();
            rectangulo.calcularBase();
            rectangulo.CalculadorArea();
            rectangulo.CalcularPerimetro();

            Console.WriteLine("El perimetro es :" + rectangulo.CalcularPerimetro());
            Console.WriteLine("El area es :" + rectangulo.CalculadorArea());
            Console.Read();

        }  
    }
}
