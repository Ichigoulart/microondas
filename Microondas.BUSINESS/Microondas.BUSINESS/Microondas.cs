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

            Console.WriteLine();
            Console.Write("     " + nome);
            for(int i=0; i < tempo; i++)
            {
                for (int j = 0; j < potencia; j++)
                {
                    Thread.Sleep(1000/potencia);
                    Console.Write(caracter);
                }
                
            }
            Console.WriteLine("\n\n     Aquecida!");

        }

        public void CozinharRapido()
        {
            Cozinhar("Cozinhar Rápido", 30, 8, '.');
        }

        public void CozinharPorTempoPotencia()
        {
            Console.Write("\n     Informe o tempo entre 1 e 120 segundos: ");
            var tempo = Console.ReadLine();
            int tempoint;
            try
            {
                tempoint = Convert.ToInt16(tempo);
            }
            catch
            {

                throw new Exception("Tempo informado inválido!");
            }
            Console.Write("\n     Informe a potencia entre 1 e 10: ");
            var potencia = Console.ReadLine();
            int potenciaint;
            try
            {
                potenciaint = Convert.ToInt16(potencia);
            }
            catch
            {

                throw new Exception("Potência informada inválida!");
            }
            Cozinhar("Cozinhando por tempo e potencia", tempoint, potenciaint, '.');
        }

        public void CozinharPrograma(Microondas microondas)
        {
            Console.Write("\n     Informe o programa para cozinhar: ");
            var alimento = Console.ReadLine();
            try
            {
                var programa = new BuscaPrograma().Buscar(alimento, microondas);
                Cozinhar(programa.Nome, programa.Tempo, programa.Potencia, programa.Caracter);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        
        public Programa BuscarPrograma(Microondas microondas)
        {
            Console.Write("\n     Informe o programa para consultar se já existe: ");
            var alimento = Console.ReadLine();
            try
            {
                var programa = new BuscaPrograma().Buscar(alimento, microondas);
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
