using System;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio4
{
    class Circulo : Figura
    {
        double PI { get; set; }
        double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
            PI = Math.PI;
        }
        public override double CalcularArea()
            => Math.Round(Area = PI * Math.Pow(Radio, 2), 2);
    }
}
