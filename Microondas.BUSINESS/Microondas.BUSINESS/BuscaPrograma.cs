using Microondas.BUSINESS.Programas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.BUSINESS
{
    public class BuscaPrograma
    {
        public Programa Buscar(string nomeAlimento, Microondas microondas)
        {
            foreach (var programa in microondas.Programas)
            {
                if (nomeAlimento.Equals(programa.Nome, StringComparison.OrdinalIgnoreCase))
                {
                    return programa;
                }
            }
            throw new Exception("Não foi encontrado um programa para o alimento informado!");
        }
    }
}
