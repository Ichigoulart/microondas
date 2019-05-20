using Microondas.BUSINESS.Programas;
using System;
using System.Threading;

namespace Microondas.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var microondas = new Microondas.BUSINESS.Microondas();
            int opcao = 99;
            do
            {
                opcao = 99;
                Console.Clear();
                Console.WriteLine("########## MICRO - ONDAS ##########");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("\n     OPÇOES:\n");
                Console.WriteLine("     1 - INICIO - RAPIDO");
                Console.WriteLine("     2 - INICIO - TEMPO E POTENCIA");
                Console.WriteLine("     3 - INICIO - PROGRAMAS");
                Console.WriteLine("     4 - LISTAR - PROGRAMAS");
                Console.WriteLine("     5 - BUSCAR - PROGRAMA");
                Console.WriteLine("     6 - ADICIONAR - PROGRAMA");
                Console.WriteLine("     0 - SAIR");
                Console.Write("\n     Informe opcao: ");
                try
                {
                    opcao = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Opcao informada inválida!");            
                }
                
                switch (opcao)
                {
                    case 1:
                        microondas.Cozinhar(new Programa("Cozinhar Rápido", 30, 8, '.', "Instrução - cozinhar rapido"));
                        Console.ReadKey();
                        break;
                    case 2:
                        new CozimentoPadrao(microondas).Cozinhar();
                        break;
                    case 3:
                        Console.Write("\n     Informe o programa para cozinhar: ");
                        var alimento = Console.ReadLine();
                        microondas.CozinharPrograma(alimento);
                        Console.ReadKey();
                        break;
                    case 4:
                        new ListagemProgramas().ListarProgramasPadrao(microondas.Programas);
                        Console.ReadKey();
                        break;
                    case 5:
                        new ConsultaPrograma(microondas).Consultar();
                        Console.ReadKey();
                        break;
                    case 6:
                        microondas.AdicionarPrograma(new AdicionarPrograma().Adicionar());
                        Console.Write("\n     Programa Adicionado!");
                        Thread.Sleep(1000);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("\n     Opcao invalida!");
                        Thread.Sleep(1000);
                        break;
                }
            } while (opcao != 0);
        }
    }
}
