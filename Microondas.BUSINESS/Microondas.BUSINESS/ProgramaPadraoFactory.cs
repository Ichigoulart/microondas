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
            Programas.Add(new Programa("Frango", 10, 5, '-', "grelhar por 30 min."));
            Programas.Add(new Programa("Linguiça", 9, 4, '*', "assar por 40 min."));
            Programas.Add(new Programa("Pipoca", 8, 7, '+', "estourar por 10 min."));
            Programas.Add(new Programa("Sopa", 7, 3, '^', "ferver por 20 min."));
            Programas.Add(new Programa("Ovo", 4, 9, '#', "fritar por 5 min."));

            return Programas;
        }
    }
}
