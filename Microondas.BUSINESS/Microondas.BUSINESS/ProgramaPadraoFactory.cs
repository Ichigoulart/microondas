using Microondas.BUSINESS.Programas;
using System.Collections.Generic;

namespace Microondas.BUSINESS
{
    public class ProgramaPadraoFactory
    {
        private List<Programa> Programas { get; set; }

        public List<Programa> ObterProgramasPadrao()
        {
            Programas = new List<Programa>();
            Programas.Add(new Programa("Frango", 10, 5, '-', "Instrução - frango"));
            Programas.Add(new Programa("Linguiça", 9, 4, '*', "Instrução - linguica"));
            Programas.Add(new Programa("Pipoca", 8, 7, '+', "Instrução - pipoca"));
            Programas.Add(new Programa("Sopa", 7, 3, '^', "Instrução - sopa"));
            Programas.Add(new Programa("Ovo", 4, 9, '#', "Instrução - ovo"));

            return Programas;
        }
    }
}
