using System;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio4
{
    class Programa
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Consola.PrintInGreen("# Figuras");
            double radio, @base, altura;

            Consola.PrintInGreen("\n## Círculo\n");
            do Console.Write("* Ingrese el radio: ");
            while (!validarLongitud(out radio));

            Circulo circulo1 = new Circulo(radio);
            Console.WriteLine($"> El área del círculo es {circulo1.CalcularArea()}");

            Consola.PrintInGreen("\n## Rectángulo\n");
            do Console.Write("* Ingrese la base: ");
            while (!validarLongitud(out @base));
            do Console.Write("* Ingrese la altura: ");
            while (!validarAlturaRect(out altura, @base));

            Rectangulo rectangulo1 = new Rectangulo(@base, altura);
            Console.WriteLine($"> El área del rectángulo es {rectangulo1.CalcularArea()}");

            Consola.PrintInGreen("\n## Triángulo\n");
            do Console.Write("* Ingrese la base: ");
            while (!validarLongitud(out @base));
            do Console.Write("* Ingrese la altura: ");
            while (!validarLongitud(out altura));

            Triangulo triangulo1 = new Triangulo(@base, altura);
            Console.WriteLine($"> El área del triángulo es {triangulo1.CalcularArea()}");

            Console.Write("Presione una tecla para salir... ");
            Console.ReadKey(true);
        }
        static bool validarLongitud(out double longitud)
        {
            bool esValido = double.TryParse(Console.ReadLine(), out longitud) && longitud > 0;
            if (!esValido) Consola.PrintInRed(" ! El valor ingresado no es válido");
            return esValido;
        }
        static bool validarAlturaRect(out double altura, double @base)
        {
            bool esValido = validarLongitud(out altura) && altura != @base;
            if (!esValido) Consola.PrintInRed(" ! La altura debe ser diferente a la base");
            return esValido;
        }
    }
}
