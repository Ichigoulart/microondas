using Microondas.BUSINESS;
using Microondas.BUSINESS.Programas;
using System;
using System.Collections.Generic;

namespace Microondas.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoInformado;
            string nomeAlimento;
            //Console.WriteLine("Informe o tempo em segundos:");
            //tempoInformado = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Informe o alimento desejado:");
            //nomeAlimento = Console.ReadLine();
            //new ConsultaPrograma().Consultar(nomeAlimento);
            var programa = new AdicionarPrograma().Adicionar();
            //var microondas = new Microondas.BUSINESS.Microondas();
            new ListagemProgramas().Listar(programa);
            Console.ReadKey();
        }
    }
}
