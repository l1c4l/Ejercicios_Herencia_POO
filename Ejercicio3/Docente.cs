using System;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio3
{
    class Docente : Persona
    {
        public string Especialidad { get; set; }
        public double Sueldo { get; set; }
        public int AñosExperiencia { get; set; }
        public Curso CursoAsignado { get; set; }

        public Docente(string dni, string nombres, string apellidos, DateTime fechaNacimiento, string especialidad, double sueldo, int añosExperiencia, Curso cursoAsignado) : base(dni, nombres, apellidos, fechaNacimiento)
        {
            Especialidad = especialidad;
            Sueldo = sueldo;
            AñosExperiencia = añosExperiencia;
            CursoAsignado = cursoAsignado;
        }
        public void IngresarNotas(Curso curso)
        {
            string codigo;
            double nota1, nota2, nota3;

            Console.Write("\n* Ingrese el código de estudiante:\n");
            codigo = Console.ReadLine();

            if (Estudiante.Estudiantes.Find(estudiante => estudiante.Codigo == codigo) != null)
            {
                Console.WriteLine("\n# Notas del estudiante\n");

                do Console.Write("* Nota 1: ");
                while (!validarNota(Console.ReadLine(), out nota1));
                do Console.Write("* Nota 2: ");
                while (!validarNota(Console.ReadLine(), out nota2));
                do Console.Write("* Nota 3: ");
                while (!validarNota(Console.ReadLine(), out nota3));
                
                curso.NotasEstudiantes.Add(new NotasEstudiante(codigo, nota1, nota2, nota3));
            }
            else
                Console.WriteLine("\n! No se ha encontrado al estudiante");
        }
        public void VisualizarRegistro(Curso curso)
        {
            Console.WriteLine("\n# Datos del curso\n");
            Console.WriteLine($"* Carrera: {curso.Carrera}");
            Console.WriteLine($"* Ciclo: {curso.Ciclo}");
            Console.WriteLine($"* Nombre: {curso.Nombre}");
            Console.WriteLine("\n# Notas de los estudiantes\n");

            Console.WriteLine("╔═════════╦════════╦════════╦════════╦══════════╗");
            Console.WriteLine("║ Código  ║ Nota 1 ║ Nota 2 ║ Nota 3 ║ Promedio ║");
            Console.WriteLine("╠═════════╬════════╬════════╬════════╬══════════╣");

            curso.NotasEstudiantes.ForEach(notasEstudiante => Console.WriteLine("║ {0,7} ║ {1,6} ║ {2,6} ║ {3,6} ║ {4,8} ║",
                notasEstudiante.Codigo, Math.Round(notasEstudiante.Nota1, 1), Math.Round(notasEstudiante.Nota2), Math.Round(notasEstudiante.Nota3), Math.Round(notasEstudiante.Promedio, 2))
            );

            Console.WriteLine("╚═════════╩════════╩════════╩════════╩══════════╝");
        }
        bool validarNota(string entrada, out double nota)
            => double.TryParse(entrada, out nota) && nota >= 0 && nota <= 20;
    }
}
