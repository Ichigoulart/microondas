using System;

namespace Microondas.UI
{
    public class ConsultaPrograma
    {
        private Microondas.BUSINESS.Microondas _microondas;

        public ConsultaPrograma(BUSINESS.Microondas microondas)
        {
            _microondas = microondas;
        }

        public void Consultar()
        {
            Console.Write("\n     Informe o programa para consultar se já existe: ");
            var alimento = Console.ReadLine();
            try
            {
                var programa = _microondas.BuscarPrograma(alimento);
                if (programa != null)
                {
                    new ListagemProgramas().Listar(programa);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
