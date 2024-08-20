using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public int Area { get; set; }

        public int Perimetro { get; set; }

        public List<Coordenada> coordenadas { get; set; }

        public Coordenada Coordenada1 { get; set; }
        public Coordenada Coordenada2 { get; set; }

        public Coordenada Coordenada3 { get; set; }

        public Coordenada Coordenada4 { get; set; }

        public void calcularBase()
        {
            int xMin;
            int xMax;

            for (int i = 0; i < coordenadas.Count; i++)
            {
                coordenadas[i].x = xMax;
                if (xMax > xMin)
                {
                    xMin = xMax;
                }
            }
        }

        public void calcularAltura()
        {
            
        }

        public int CalculadorArea()
        {
            return Base * Altura;
        }

        public int CalcularPerimetro()
        {
            return 2*(Base + Altura);
        }
    }
}
