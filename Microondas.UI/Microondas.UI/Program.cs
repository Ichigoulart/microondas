using Microondas.BUSINESS;
using Microondas.BUSINESS.Programas;
using System;
using System.Collections.Generic;
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
                catch (Exception e)
                {            
                }
                
                switch (opcao)
                {
                    case 1:
                        new Microondas.BUSINESS.Microondas().CozinharRapido();
                        Console.ReadKey();
                        break;
                    case 2:
                        new Microondas.BUSINESS.Microondas().CozinharPorTempoPotencia();
                        Console.ReadKey();
                        break;
                    case 3:
                        new Microondas.BUSINESS.Microondas().CozinharPrograma(microondas);
                        Console.ReadKey();
                        break;
                    case 4:
                        new ListagemProgramas().ListarProgramasPadrao(microondas.Programas);
                        Console.ReadKey();
                        break;
                    case 5:
                        var resultado2 = new Microondas.BUSINESS.Microondas().BuscarPrograma(microondas);
                        if(resultado2 != null)
                        { 
                            new ListagemProgramas().Listar(resultado2);
                        }
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
