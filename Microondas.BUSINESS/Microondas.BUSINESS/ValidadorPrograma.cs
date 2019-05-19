using Microondas.BUSINESS.Programas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.BUSINESS
{
    public class ValidadorPrograma
    {
        public void Validar(Programa  programa)
        {
            if (programa.Tempo == 0)
                throw new Exception("O tempo não foi informado!");

            if (programa.Tempo < 1 || programa.Tempo > 120)
                throw new Exception("O tempo informado deve estar entre 1 e 120 segundos.");

            if (programa.Potencia < 1 || programa.Potencia > 10)
                throw new Exception("A potência informada deve estar entre 1 e 10");
        }
    }
}
