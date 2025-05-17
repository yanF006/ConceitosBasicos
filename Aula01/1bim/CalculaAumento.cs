using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalculaAumento
    {
        float salarioInicial;
        float salarioFinal;
        float aumento;
        public void Aumentar()
        {
            try
            {
                Console.WriteLine("Qual o valor do salário inicial? ");
                salarioInicial = float.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Número inválido");
                return;
            }
            try
            {
                Console.WriteLine("Qual o percentual do aumento? ");
                aumento = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Número inválido");
                return;
            }
            salarioFinal = salarioInicial + salarioInicial * (aumento / 100);
            Console.WriteLine($"O salário inicial é: " + salarioInicial);
            Console.WriteLine($"O percentual é: " + aumento);
            Console.WriteLine($"O valor do aumento é: " + (salarioFinal - salarioInicial));
            Console.WriteLine($"O salário final é: " + salarioFinal);
        }
    }
}
