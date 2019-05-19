using Microondas.BUSINESS;
using Microondas.BUSINESS.Programas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.UI
{
    public class AdicionarPrograma
    {
        private Programa _programa;

        public AdicionarPrograma()
        {
            _programa = new Programa();
        }

        public Programa Adicionar()
        {
            Console.WriteLine("Informe o nome do alimento:");
            var nome = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Nome informado é inválido!");
            }
            _programa.Nome = nome;
            Console.WriteLine("Informe o tempo do alimento:");
            var tempo = Console.ReadLine();
            try
            {
                _programa.Tempo = Convert.ToInt16(tempo);
            }
            catch
            {

                throw new Exception("Tempo informado inválido!");
            }
            Console.WriteLine("Informe a potencia do alimento:");
            var potencia = Console.ReadLine();
            try
            {
                _programa.Potencia = Convert.ToInt16(potencia);
            }
            catch
            {

                throw new Exception("Potência informada inválida!");
            }
            Console.WriteLine("Informe o caracter do alimento:");
            var caracter = Console.ReadLine();
            try
            {
                _programa.Caracter = Convert.ToChar(caracter);
            }
            catch
            {

                throw new Exception("Caracter informado é inválido!");
            }
            Console.WriteLine("Informe as instruções do alimento:");
            var instrucao = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(instrucao))
            {
                throw new Exception("Instrução do alimento não informado!");
            }
            _programa.Instrucao = instrucao;

            return new Microondas.BUSINESS.Microondas().AdicionarPrograma(_programa);

        }
    }
}
