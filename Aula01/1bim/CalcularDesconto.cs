using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    internal class CalcularDesconto
    {
        float valorInicial, valorFinal, desconto;
        public void descontador()
        {
            try
            {
                Console.WriteLine("Qual o valor do produto? ");
                valorInicial = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Número inválido");
            }
            try
            {
                Console.WriteLine("Quantos porcentos será o desconto? ");
                desconto = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Número inválido");
            }
            valorFinal = valorInicial * (1 - desconto / 100);
            Console.WriteLine($"O valor do produto é: " + valorInicial);
            Console.WriteLine($"O percentual do desconto é: " + desconto);
            Console.WriteLine($"Valor do desconto: " + (valorInicial - valorFinal));
            Console.WriteLine($"O valor após os descontos é: " + valorFinal);
        }
    }
}
