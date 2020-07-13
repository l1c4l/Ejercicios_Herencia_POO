using System;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio3
{
    class Programa
    {
        static void Main()
        {
            Console.WriteLine("\nPERSONAS");
            Console.WriteLine("========\n");

            Persona persona1 = new Persona("76368626", "Abraham", "Lipa", new DateTime(1997, 10, 21));
            Persona persona2 = new Persona("71792310", "Juan", "Torres", new DateTime(1995, 3, 11));

            persona1.HablarCon(persona2);
            if (persona1.EstaHablando)
                Console.WriteLine($"* {persona1.Nombres} está hablando");
            if (persona2.EstaEscuchando)
                Console.WriteLine($"* {persona2.Nombres} está escuchando\n");

            persona1.EscucharA(persona2);
            if (persona1.EstaEscuchando)
                Console.WriteLine($"* {persona1.Nombres} está escuchando");
            if (persona2.EstaHablando)
                Console.WriteLine($"* {persona2.Nombres} está hablando");

            Console.WriteLine("\nDOCENTE Y ESTUDIANTES");
            Console.WriteLine("=====================");

            Curso curso1 = new Curso("Ingeniería de Sistemas", 4, "Introducción al Diseño Web");
            Docente docente1 = new Docente("00238912", "Pedro", "Gutierrez", new DateTime(1983, 10, 21), "Desarrollo Web", 2900, 8, curso1);

            Estudiante estudiantes = new Estudiante();

            //Registra a 2 estudiantes
            Estudiante estudiante1 = new Estudiante("76368626", "Abraham", "Lipa", new DateTime(1997, 10, 21));
            Estudiante estudiante2 = new Estudiante("76234238", "Alberto", "Gomez", new DateTime(1998, 3, 1));

            // Registra a 2 estudiantes
            estudiantes.RegistrarEstudiante();
            estudiantes.RegistrarEstudiante();

            // Ingresa las notas de los 4 estudiantes
            docente1.IngresarNotas(curso1);
            docente1.IngresarNotas(curso1);
            docente1.IngresarNotas(curso1);
            docente1.IngresarNotas(curso1);

            docente1.VisualizarRegistro(curso1);

            estudiante1.VisualizarNotas(curso1);
            estudiante2.VisualizarNotas(curso1);

            Console.ReadKey(true);
        }
    }
}
