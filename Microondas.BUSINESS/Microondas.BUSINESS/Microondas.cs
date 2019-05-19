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

        public void Cozinhar(string nome, int tempo, int potencia, char caracter)
        {
            if (tempo == 0)
                throw new Exception("O tempo não foi informado!");
            
            if (tempo < 1 || tempo > 120)
                throw new Exception("O tempo informado deve estar entre 1 e 120 segundos.");

            if (potencia < 1 || potencia > 10)
                throw new Exception("A potência informada deve estar entre 1 e 10");

            Console.Write(nome);
            for(int i=0; i < tempo; i++)
            {
                for (int j = 0; j < potencia; j++)
                {
                    Thread.Sleep(1000/potencia);
                    Console.Write(caracter);
                }
                
            }
            Console.WriteLine("Aquecida!");

        }

        public void CozinharRapido()
        {
            Cozinhar("Cozinhar Rápido", 30, 8, '.');
        }


    }
}
