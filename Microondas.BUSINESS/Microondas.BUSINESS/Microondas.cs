using Microondas.BUSINESS.Programas;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Microondas.BUSINESS
{
    public class Microondas
    {

        public List<Programa> Programas { get; set; }

        public Microondas()
        {
            Programas = new ProgramaPadraoFactory().ObterProgramasPadrao();
        }

        public Programa AdicionarPrograma(Programa programa)
        {
            new ValidadorPrograma().Validar(programa.Tempo, programa.Potencia);
            Programas.Add(programa);
            return programa;
        }

        public void Cozinhar(string nome, int tempo, int potencia, char caracter)
        {
            Console.WriteLine();
            Console.Write("     " + nome);
            for (int i = 0; i < tempo; i++)
            {
                for (int j = 0; j < potencia; j++)
                {
                    Thread.Sleep(1000 / potencia);
                    Console.Write(caracter);
                }

            }
            Console.WriteLine("\n\n     Aquecida!");
        }
        
        public void CozinharPrograma(string alimento)
        {
            try
            {
                var programa = new BuscaPrograma().Buscar(alimento, this);
                Cozinhar(programa.Nome, programa.Tempo, programa.Potencia, programa.Caracter);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        
        public Programa BuscarPrograma(string alimento)
        {
            try
            {
                var programa = new BuscaPrograma().Buscar(alimento, this);
                return programa;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
