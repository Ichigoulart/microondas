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
                catch (Exception e)
                {
                    Console.WriteLine("Opcao informada inválida!");            
                }
                
                switch (opcao)
                {
                    case 1:
                        microondas.Cozinhar("Cozinhar Rápido", 30, 8, '.');
                        Console.ReadKey();
                        break;
                    case 2:
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
                        new ValidadorPrograma().Validar(tempoint,potenciaint);
                        microondas.Cozinhar("Cozinhando por tempo e potencia", tempoint, potenciaint, '.');
                        Console.ReadKey();
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
                        Console.Write("\n     Informe o programa para consultar se já existe: ");
                        var alimento2 = Console.ReadLine();
                        var resultado2 = microondas.BuscarPrograma(alimento2);
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
