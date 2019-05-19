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
        public void Validar(int tempo, int potencia)
        {
            if (tempo == 0)
                throw new Exception("O tempo não foi informado!");

            if (tempo < 1 || tempo > 120)
                throw new Exception("O tempo informado deve estar entre 1 e 120 segundos.");

            if (potencia < 1 || potencia > 10)
                throw new Exception("A potência informada deve estar entre 1 e 10");
        }
    }
}
