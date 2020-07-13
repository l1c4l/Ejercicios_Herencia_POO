using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio3
{
    class Curso
    {
        public List<NotasEstudiante> NotasEstudiantes;
        public string Carrera { get; set; }
        public int Ciclo { get; set; }
        public string Nombre { get; set; }

        public Curso(string carrera, int ciclo, string nombre)
        {
            Carrera = carrera;
            Ciclo = ciclo;
            Nombre = nombre;

            NotasEstudiantes = new List<NotasEstudiante>();
        }
    }
}
