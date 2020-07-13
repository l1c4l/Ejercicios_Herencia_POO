using System;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio2
{
    class Programa
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("# Vehículo\n");

            Vehiculo vehiculo1 = new Vehiculo("FFF-FFF", ConsoleColor.White, "M3", 2005, "BMW", TipoFrenoVehiculo.DeDisco);
            
            vehiculo1.Acelerar();
            vehiculo1.CambiarVelocidad();
            vehiculo1.Frenar();
            vehiculo1.Retroceder();

            MostrarDetallesVehiculo(vehiculo1);

            Console.WriteLine("# Camión\n");

            Camion camion1 = new Camion("12F-45D", ConsoleColor.Red, "T33", 2012, "Volvo", TipoFrenoVehiculo.DeMano, 1500, 3);

            camion1.Acelerar();
            camion1.CambiarVelocidad();
            camion1.Frenar();
            camion1.Retroceder();

            // Métodos de Camión
            camion1.Cargar();
            camion1.Descargar();
            camion1.Cargar();

            MostrarDetallesVehiculo(camion1);

            Console.WriteLine("# Automóvil\n");

            Automovil automovil1 = new Automovil("FG1-DG4", ConsoleColor.Black, "Tesla", 2015, "S", TipoFrenoVehiculo.ABS, 4, "Deportivo");

            automovil1.Acelerar();
            automovil1.CambiarVelocidad();
            automovil1.Retroceder();
            automovil1.Frenar();

            MostrarDetallesVehiculo(automovil1);

            Console.ReadKey(true);
        }
        static void MostrarDetallesVehiculo(Vehiculo vehiculo)
        {
            Console.WriteLine("\n# Detalles del vehículo\n" +
                $"\n* Número de placa: {vehiculo.NumeroPlaca}" +
                $"\n* Marca: {vehiculo.Marca}" +
                $"\n* Modelo: {vehiculo.Modelo}" +
                $"\n* Año: {vehiculo.Año}" +
                $"\n* Color: {vehiculo.Color}");

            if (vehiculo is Automovil)
                Console.WriteLine($"\n* Cantidad de puertas: {((Automovil)vehiculo).CantidadPuertas}" +
                    $"\n* Tipo de automóvil: {((Automovil)vehiculo).TipoAutomovil}");

            else if (vehiculo is Camion)
                Console.WriteLine($"\n* Capacidad de carga: {((Camion)vehiculo).CapacidadCarga}" +
                    $"\n* Número de ejes: {((Camion)vehiculo).NumeroEjes}");
        }
    }
}
