using System;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio2
{
    class Camion : Vehiculo
    {
        double CargaActual { get; set; }
        public double CapacidadCarga { get; set; }
        public int NumeroEjes { get; set; }

        public Camion(string numeroPlaca, ConsoleColor color, string modelo, int año, string marca, TipoFrenoVehiculo tipoFreno, int capacidadCarga, int numeroEjes) : base (numeroPlaca, color, modelo, año, marca,  tipoFreno)
        {
            CapacidadCarga = capacidadCarga;
            NumeroEjes = numeroEjes;
        }
        public void Cargar()
        {
            double carga;
            
            do Console.Write("* Ingrese el peso de la carga a cargar: ");
            while (!validarPositivo(Console.ReadLine(), out carga));

            if (validarCarga(carga))
                Console.WriteLine($"> Se han cargado {carga} kg.");
            else
                Console.WriteLine("! No se puede cargar por encima de la capacidad del camión");

            MostrarCargaActual();

        }
        public void Descargar()
        {
            double descarga;

            do Console.Write("* Ingrese el peso de la carga a descargar: ");
            while (!validarPositivo(Console.ReadLine(), out descarga));

            if (validarDescarga(descarga))
                Console.WriteLine($"> Se han descargado {descarga} kg.");
            else
                Console.WriteLine("! Hay menos carga de la indicada");
            
            MostrarCargaActual();
        }
        bool validarPositivo(string entrada, out double tiempo)
            => double.TryParse(entrada, out tiempo) && tiempo > 0;
        bool validarCarga(double carga) => CargaActual + carga <= CapacidadCarga;
        bool validarDescarga(double descarga) => CargaActual - descarga >= 0;
        void MostrarCargaActual()
        {
            if (CargaActual == 0)
                Console.WriteLine("> El camión no tiene carga (Carga actual: 0)");
            else
                Console.WriteLine($"El camión tiene una carga de {CargaActual} kg.");
        }
    }
}
