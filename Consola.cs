using System;

namespace Ejercicios_Herencia_POO_Lipa
{
    public static class Consola
    {
        public static void PrintInGreen(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(texto);
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public static void PrintInRed(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(texto);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
