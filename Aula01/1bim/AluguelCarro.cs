using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    internal class AluguelCarro
    {
        float quilometragemInicial, quilometragemFinal, totalDiasAlugados, valorFinal;
        public void alugador()
        {
            try
            {
                Console.WriteLine("Quantos dias foi alugado o carro? ");
                totalDiasAlugados = float.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Valor inválido");
                return;
            }
            try
            {
                Console.WriteLine("Qual a quilometragem inicial? ");
                quilometragemInicial = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor inválido");
                return;
            }
            try
            {
                Console.WriteLine("E qual a quilometragem final? ");
                quilometragemFinal = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor inválido");
                return;
            }
            valorFinal = ((quilometragemFinal - quilometragemInicial) * 35 / 100) + totalDiasAlugados * 95;
            Console.WriteLine("O valor do aluguel será: " + valorFinal);
        }
    }
}
