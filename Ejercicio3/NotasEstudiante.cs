namespace Ejercicios_Herencia_POO_Lipa.Ejercicio3
{
    class NotasEstudiante
    {
        public string Codigo { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Promedio { get; set; }

        public NotasEstudiante(string codigo, double nota1, double nota2, double nota3)
        {
            Codigo = codigo;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;

            Promedio = (nota1 + nota2 + nota3) / 3;
        }
    }
}
