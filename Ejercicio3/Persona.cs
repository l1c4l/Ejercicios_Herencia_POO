using System;

namespace Ejercicios_Herencia_POO_Lipa.Ejercicio3
{
    class Persona
    {
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }

        bool estaHablando,
            estaEscuchando;

        public Persona() { }
        public Persona(string dni, string nombres, string apellidos, DateTime fechaNacimiento)
        {
            DNI = dni;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
        }

        public bool EstaHablando
        {
            get => estaHablando;
            set => estaEscuchando = !(estaHablando = value);
        }
        public bool EstaEscuchando
        {
            get => estaEscuchando;
            set => estaHablando = !(estaEscuchando = value);
        }

        public void HablarCon(Persona persona)
            => EstaHablando = persona.EstaEscuchando = true;
        public void EscucharA(Persona persona)
            => EstaEscuchando = persona.EstaHablando = true;
    }
}
