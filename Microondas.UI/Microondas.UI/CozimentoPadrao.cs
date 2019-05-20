using Microondas.BUSINESS;
using Microondas.BUSINESS.Programas;
using System;

namespace Microondas.UI
{
    public class CozimentoPadrao
    {
        private Microondas.BUSINESS.Microondas _microondas;

        public CozimentoPadrao(BUSINESS.Microondas microondas)
        {
            _microondas = microondas;
        }

        public void Cozinhar()
        {
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
            var programaPadrao = new Programa("Cozinhando por tempo e potencia", tempoint, potenciaint, '.', "Intrução - padrão");

            new ValidadorPrograma().Validar(programaPadrao);
            _microondas.Cozinhar(programaPadrao);
            Console.ReadKey();
        }
    }
}
