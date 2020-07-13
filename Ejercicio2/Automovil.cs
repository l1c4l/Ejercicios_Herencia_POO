using System;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio2
{
    class Automovil : Vehiculo
    {
        public int CantidadPuertas { get; set; }
        public string TipoAutomovil { get; set; }

        public Automovil(string numeroPlaca, ConsoleColor color, string modelo, int año, string marca, TipoFrenoVehiculo tipoFreno, int cantidadPuertas, string tipoAutomovil) : base(numeroPlaca, color, modelo, año, marca,  tipoFreno)
        {
            CantidadPuertas = cantidadPuertas;
            TipoAutomovil = tipoAutomovil;
        }
    }
}
