﻿using Microondas.BUSINESS.Programas;
using System;
using System.Collections.Generic;

namespace Microondas.UI
{
    public class ListagemProgramas
    {
        public void ListarProgramasPadrao(List<Programa> programas)
        {
            Console.Clear();
            Console.WriteLine("******* LISTA DE PROGRAMAS *******");
            foreach (var programa in programas)
            {
                Listar(programa);
            }
        }

        public void Listar(Programa programa)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\n     Nome: " + programa.Nome);
            Console.WriteLine("     Tempo: " + programa.Tempo);
            Console.WriteLine("     Potência: " + programa.Potencia);
            Console.WriteLine("     Caracter: " + programa.Caracter);
            Console.WriteLine("     Instrução: " + programa.Instrucao);
        }
    }
}