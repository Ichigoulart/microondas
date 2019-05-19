using System;

namespace Microondas.BUSINESS.Programas
{
    public class Programa
    {
        public string Nome { get; set; }
        public int Tempo { get; set; }
        public int Potencia { get; set; }
        public char Caracter { get; set; }
        public string Instrucao { get; set; }

        public Programa()
        {

        }

        public Programa(string nome, int tempo, int potencia, char caracter, string instrucao)
        {
            Nome = nome;
            Tempo = tempo;
            Potencia = potencia;
            Caracter = caracter;
            Instrucao = instrucao;
        }
    }
}
