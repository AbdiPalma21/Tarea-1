using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ClaseContenedora
    {
        private class Rectangulo
        {
            public double Longitud { get; set; }
            public double Ancho { get; set; }

            public Rectangulo(double longitud, double ancho)
            {
                Longitud = longitud;
                Ancho = ancho;
            }

            public double CalcularArea()
            {
                return Longitud * Ancho;
            }

            public double CalcularPerimetro()
            {
                return 2 * (Longitud + Ancho);
            }
        }

        public void DemostrarRectangulo()
        {
            // Instanciar Rectangulo y mostrar su área y perímetro
            Rectangulo miRectangulo = new Rectangulo(10.0, 20.0);
            Console.WriteLine($"Área: {miRectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {miRectangulo.CalcularPerimetro()}");
        }
    }
}
