using System;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //----------------- procedimiental --------------------------
        Console.WriteLine("--------------- Ejercicio procedimental ---------------");
        // Solicitar al usuario la longitud y el ancho del rectángulo
        Console.WriteLine("Ingrese la longitud del rectángulo:");
        double longitud = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el ancho del rectángulo:");
        double ancho = Convert.ToDouble(Console.ReadLine());

        // Calcular el área y el perímetro
        double area = CalcularArea(longitud, ancho);
        double perimetro = CalcularPerimetro(longitud, ancho);

        // Mostrar resultados
        Console.WriteLine($"El área del rectángulo es: {area}");
        Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");

        //----------------- Modular--------------------------
        Console.WriteLine("--------------- Ejercicio Modular---------------");
        Console.WriteLine("Ingrese la longitud del rectángulo:");
        double longitudModular = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el ancho del rectángulo:");
        double anchoModular = Convert.ToDouble(Console.ReadLine());

        Rectangulo rectangulo = new Rectangulo(longitudModular, anchoModular);

        double areaModular = rectangulo.CalcularArea();
        double perimetroModular = rectangulo.CalcularPerimetro();

        Console.WriteLine($"El área del rectángulo es: {areaModular}");
        Console.WriteLine($"El perímetro del rectángulo es: {perimetroModular}");

        //----------------- Ejercicio clase privada --------------------------
        Console.WriteLine("--------------- Ejercicio clase Privada con datos quemados ---------------");
        ClaseContenedora contenedora = new ClaseContenedora();

        contenedora.DemostrarRectangulo();

    }

    static double CalcularArea(double longitud, double ancho)
    {
        return longitud * ancho;
    }

    static double CalcularPerimetro(double longitud, double ancho)
    {
        return 2 * (longitud + ancho);
    }
}
