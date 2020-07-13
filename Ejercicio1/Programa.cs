using System;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio1
{
    class Programa
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            double x, y;

            Console.WriteLine("PUNTOS");
            Console.WriteLine("======\n");

            Punto punto1 = new Punto();
            Punto punto2 = new Punto(0, 0);

            Console.WriteLine("# Punto 1");
            Console.WriteLine("Ingrese la posición del punto:");

            do Console.Write("* x = ");
            while (!double.TryParse(Console.ReadLine(), out x));
            do Console.Write("* y = ");
            while (!double.TryParse(Console.ReadLine(), out y));
            punto1.X = x;
            punto1.Y = y;

            Console.WriteLine("\n# Datos del punto");
            punto1.VisualizarPunto();

            Console.WriteLine("\n# Punto 2");
            Console.WriteLine("\n# Datos del punto");
            punto2.VisualizarPunto();

            Console.WriteLine("CÍRCULOS");
            Console.WriteLine("========\n");

            Circulo circulo1 = new Circulo(punto1); // especifica punto central
            Circulo circulo2 = new Circulo(punto2, 2); // especifica punto central y radio
            Circulo circulo3 = new Circulo();

            Console.WriteLine("# Círculo 1");
            circulo1.CalcularRadio(new Punto(1, 1));

            Console.WriteLine("\n# Datos del punto central del círculo");
            circulo1.VisualizarPunto();

            Console.WriteLine("# Círculo 1");
            Console.WriteLine("\n# Datos del círculo" +
                $"\n* Área: {circulo1.CalcularArea()}" +
                $"\n* Circunferencia: {circulo1.CalcularCircunferencia()}" +
                $"\n* Diámetro: {circulo1.CalcularDiametro()}");

            Console.WriteLine("\n# Círculo 2");

            Console.WriteLine("\n# Datos del punto central del círculo");
            circulo2.VisualizarPunto();

            Console.WriteLine("\n# Círculo 2");
            Console.WriteLine("\n# Datos del círculo" +
                $"\n* Área: {circulo2.CalcularArea()}" +
                $"\n* Circunferencia: {circulo2.CalcularCircunferencia()}" +
                $"\n* Diámetro: {circulo2.CalcularDiametro()}");

            Console.WriteLine("\n# Círculo 3");

            circulo3.IngresarPunto(2, 2);
            circulo3.CalcularRadio(new Punto(5, 5));

            Console.WriteLine("\n# Datos del punto central del círculo");
            circulo2.VisualizarPunto();

            Console.WriteLine("\n# Círculo 3");
            Console.WriteLine("\n# Datos del círculo" +
                $"\n* Área: {circulo2.CalcularArea()}" +
                $"\n* Circunferencia: {circulo2.CalcularCircunferencia()}" +
                $"\n* Diámetro: {circulo2.CalcularDiametro()}");

            Console.ReadKey();
        }
    }
}
