using System;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio1
{
    class Punto
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punto() { }
        public Punto(double x, double y)
        {
            X = x;
            Y = y;
        }
        public void IngresarPunto(double x, double y)
        {
            X = x;
            Y = y;
        }
        public void VisualizarPunto()
        {
            Console.WriteLine("\nEl punto está ubicado en:" +
                $"\n* x = {X}" +
                $"\n* y = {Y}" +
                "\n\nPresione una tecla para ver la posición del punto...");
            Console.ReadKey(true);

            Console.Clear();
            int limite;
            dibujarGrafico();
            imprimirLimites();
            dibujarPunto();

            Console.SetCursorPosition(0, 23);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();

            void dibujarGrafico()
            {
                Console.WriteLine();
                for (int i = 0; i <= 20; i++)
                {
                    for (int j = 0; j <= 40; j++)
                    {
                        if (i == 0)
                            if (j == 0) Console.Write("╔");
                            else if (j == 20) Console.Write("╦");
                            else if (j == 40) Console.Write("╗");
                            else Console.Write("═");
                        else if (i == 10)
                            if (j == 0) Console.Write("╠");
                            else if (j == 20) Console.Write("╬");
                            else if (j == 40) Console.Write("╣");
                            else Console.Write("═");
                        else if (i == 20)
                            if (j == 0) Console.Write("╚");
                            else if (j == 20) Console.Write("╩");
                            else if (j == 40) Console.Write("╝");
                            else Console.Write("═");
                        else
                            if (j == 0 || j == 20 || j == 40)
                            Console.Write("║");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            void dibujarPunto()
            {
                int offsetX = 20, offsetY = 11;
                int xGrafico = calcularPosicionEnGrafico(X, limite) * 2;
                int yGrafico = calcularPosicionEnGrafico(Y, limite);
                Console.SetCursorPosition(xGrafico + offsetX, -yGrafico + offsetY);
                Console.Write("*");

                Console.CursorTop++;
                Console.CursorLeft--;
                Console.Write("│");

                Console.CursorTop++;
                Console.CursorLeft--;
                Console.Write($"└── P({X}, {Y})");
            }
            void imprimirLimites()
            {
                limite = calcularLimite();
                Console.SetCursorPosition(20, 0);
                Console.Write($"y {limite}");
                Console.SetCursorPosition(41, 11);
                Console.Write($"x {limite}");
            }
            int calcularLimite()
            {
                double mayor = X > Y ? X : Y;
                string stringMayor = mayor.ToString().Replace("-", "");
                stringMayor = stringMayor.Contains(".") ? stringMayor.Remove(stringMayor.IndexOf('.')) : stringMayor;
                int ceros = stringMayor.Length;
                return int.Parse(Math.Pow(10, ceros).ToString());
            }
            int calcularPosicionEnGrafico (double valor, int limiteP)
            {
                if (valor == 0) return 0;
                else
                {
                    double valorRelativo = valor / double.Parse(limiteP.ToString());
                    string stringValorRelativo = valorRelativo.ToString("#0.0#").Replace("-", "");
                    string digito = valorRelativo < 0 ? "-" + stringValorRelativo[2] : stringValorRelativo[2].ToString();
                    return digito == "0" ? 1 : int.Parse(digito);
                }
            }
        }
    }
}
