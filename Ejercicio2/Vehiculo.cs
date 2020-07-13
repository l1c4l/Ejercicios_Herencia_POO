using System;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio2
{
    class Vehiculo
    {
        static double aceleracionIdeal = 9.80665;
        public string NumeroPlaca { get; set; }
        public ConsoleColor Color { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Marca { get; set; }
        public TipoFrenoVehiculo TipoFreno { get; set; }
        double Velocimetro { get; set; }

        public Vehiculo(string numeroPlaca, ConsoleColor color, string modelo, int año, string marca, TipoFrenoVehiculo tipoFreno)
        {
            NumeroPlaca = numeroPlaca;
            Color = color;
            Modelo = modelo;
            Año = año;
            Marca = marca;
            TipoFreno = tipoFreno;

            Velocimetro = 0;
        }

        public void Acelerar()
        {
            double tiempo;

            do Console.Write("* Ingrese el tiempo de aceleración (s): ");
            while (!validarPositivo(Console.ReadLine(), out tiempo));

            Velocimetro += tiempo * aceleracionIdeal;

            Console.WriteLine($"> Se ha acelerado por {Math.Round(tiempo, 1)} segundos...");
            MostrarVelocidad();
        }
        public void Frenar()
        {
            double desaceleracion;

            switch (TipoFreno)
            {
                case TipoFrenoVehiculo.DeDisco: desaceleracion = 7; break;
                case TipoFrenoVehiculo.DeTambor: desaceleracion = 8; break;
                case TipoFrenoVehiculo.ABS: desaceleracion = 9; break;
                case TipoFrenoVehiculo.DeMano: desaceleracion = 10; break;
                default: desaceleracion = 0; break;
            }

            double tiempo = Velocimetro / desaceleracion;
            Velocimetro = 0;

            Console.WriteLine($"> Se ha conseguido frenar completamente despues de {Math.Round(tiempo, 1)} segundos...");
            MostrarVelocidad();
        }
        public void CambiarVelocidad()
        {
            double velocidad, tiempo;

            do Console.Write("* Ingrese la velocidad (km/h): ");
            while (!validarPositivo(Console.ReadLine(), out velocidad));

            velocidad /= 3.6;
            tiempo = Math.Abs(Velocimetro - velocidad) / aceleracionIdeal;
            Velocimetro = velocidad;

            Console.WriteLine($"> Se ha conseguido cambiar la velocidad despues de {Math.Round(tiempo, 1)} segundos");
            MostrarVelocidad();
        }
        public void Retroceder()
        {
            if (Velocimetro == 0)
            {
                double distancia;

                do Console.Write("* Ingrese la distancia (m): ");
                while (!validarPositivo(Console.ReadLine(), out distancia));

                Console.WriteLine($"> El vehículo ha retrocedido {distancia} metros...");
            } else
                Console.WriteLine("! El vehículo no puede retroceder si no está detenido");
            MostrarVelocidad();
        }

        bool validarPositivo(string entrada, out double tiempo)
            => double.TryParse(entrada, out tiempo) && tiempo > 0;
        double convertirAKmph(double velocidadMps) => Math.Round(velocidadMps * 3.6, 2);
        void MostrarVelocidad()
        {
            if (Velocimetro == 0)
                Console.WriteLine("> El vehículo está detenido (Velocidad: 0)\n");
            else
                Console.WriteLine($"> La velocidad actual es {convertirAKmph(Velocimetro)} km/h\n");
        }
    }
    public enum TipoFrenoVehiculo { DeDisco = 1, DeTambor, ABS, DeMano}
}
