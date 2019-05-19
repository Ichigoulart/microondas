using Microondas.BUSINESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.UI
{
    public class ConsultaPrograma
    {
        public void Consultar(string nomeAlimento, Microondas.BUSINESS.Microondas microondas)
        {
            try
            {
                var programa = new BuscaPrograma().Buscar(nomeAlimento, microondas);
                new ListagemProgramas().Listar(programa);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
