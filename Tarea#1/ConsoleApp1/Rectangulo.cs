using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangulo
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
}
