using System;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio4
{
    class Triangulo : Figura
    {
        double Base { get; set; }
        double Altura { get; set; }

        public Triangulo(double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }
        public override double CalcularArea()
            => Math.Round(Area = Base * Altura / 2, 2);
    }
}
