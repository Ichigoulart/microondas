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
            new ValidadorPrograma().Validar(programa);
            Programas.Add(programa);
            return programa;
        }

        public void Cozinhar(Programa programa)
        {
            Console.WriteLine();
            Console.Write("     " + programa.Nome);
            for (int i = 0; i < programa.Tempo; i++)
            {
                for (int j = 0; j < programa.Potencia; j++)
                {
                    Thread.Sleep(1000 / programa.Potencia);
                    Console.Write(programa.Caracter);
                }

            }
            Console.WriteLine("\n\n     Aquecida!");
        }
        
        public void CozinharPrograma(string alimento)
        {
            try
            {
                var programa = BuscarPrograma(alimento);
                Cozinhar(programa);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public Programa BuscarPrograma(string alimento)
        {
            foreach (var programa in Programas)
            {
                if (alimento.Equals(programa.Nome, StringComparison.OrdinalIgnoreCase))
                {
                    return programa;
                }
            }
            throw new Exception("Não foi encontrado um programa para o alimento informado!");
        }
    }
}
