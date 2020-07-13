using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio3
{
    class Estudiante : Persona
    {
        public static List<Estudiante> Estudiantes;
        public string Codigo { get; set; }

        public Estudiante()
        {
            Estudiantes = new List<Estudiante>();
        }
        public Estudiante(string dni, string nombres, string apellidos, DateTime fechaNacimiento) : base(dni, nombres, apellidos, fechaNacimiento)
        {
            Codigo = Apellidos.Substring(0, 3) + DNI.Substring(4, 4);

            Estudiantes.Add(this);
        }
        public void VisualizarNotas(Curso curso)
        {
            List<NotasEstudiante> notasEstudiantesFiltradas = curso.NotasEstudiantes
                .Where(notasEstudiante => notasEstudiante.Codigo == Codigo).ToList();

            if (notasEstudiantesFiltradas.Count() == 1)
            {
                NotasEstudiante notasEstudiante = notasEstudiantesFiltradas.First();

                Console.WriteLine("\n# Datos del estudiante\n");
                Console.WriteLine($"* Código: {Codigo}");
                Console.WriteLine($"* Nombres: {Nombres}");
                Console.WriteLine($"* Apellidos: {Apellidos}");

                Console.WriteLine("\n# Notas del estudiante\n");
                Console.WriteLine($"* Nota 1: {notasEstudiante.Nota1}");
                Console.WriteLine($"* Nota 2: {notasEstudiante.Nota2}");
                Console.WriteLine($"* Nota 3: {notasEstudiante.Nota3}");
                Console.WriteLine($"* Promedio: {notasEstudiante.Promedio}");
            }
        }
        public void RegistrarEstudiante()
        {
            string dni, nombres, apellidos;
            DateTime fechaNacimiento;

            Console.WriteLine("\n# Datos personales del estudiante\n");

            do
            {
                Console.Write("* Ingrese el DNI: ");
                dni = Console.ReadLine();
            }
            while (!ValidarDNI(dni));

            Console.Write("* Ingrese los nombres: ");
            nombres = Console.ReadLine();
            Console.Write("* Ingrese los apellidos: ");
            apellidos = Console.ReadLine();

            do Console.Write("* Ingrese la fecha de nacimiento: ");
            while (!DateTime.TryParse(Console.ReadLine(), out fechaNacimiento));

            Estudiantes.Add(new Estudiante(dni, nombres, apellidos, fechaNacimiento));
        }
        bool ValidarDNI(string entrada) => entrada.Length == 8;
    }
}
