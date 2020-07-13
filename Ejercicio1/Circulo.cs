using System;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio1
{
    class Circulo : Punto
    {
        public double Radio { get; set; }

        public Circulo() { }
        public Circulo(Punto puntoCentro) : base(puntoCentro.X, puntoCentro.Y) { }
        public Circulo(Punto puntoCentro, double radio) : base(puntoCentro.X, puntoCentro.Y)
        {
            Radio = radio;
        }
        public double CalcularArea()
            => Math.PI * Math.Pow(Radio, 2);
        public double CalcularCircunferencia()
            => 2 * Math.PI * Radio;
        public void CalcularRadio(Punto puntoCircunferencia)
        {
            if (puntoCircunferencia.X == X && puntoCircunferencia.Y == Y)
                Console.WriteLine("! Los puntos no pueden tener las mismas posiciones");
            else
                Radio = Math.Sqrt(Math.Pow(X - puntoCircunferencia.X, 2) + Math.Pow(Y - puntoCircunferencia.Y, 2));
        }
        public double CalcularDiametro()
            => Radio * 2;
    }
}
