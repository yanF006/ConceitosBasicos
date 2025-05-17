using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalcularAposentadoria
    {
        int idade;
        int idadeAposentadoria;
        float valorMensal;
        float taxaRendimento;
        float valorTotal;

        public float calcularRenda()
        {
            valorTotal = 0;

            try
            {
                Console.Write("Entre com a sua idade: ");
                idade = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("A idade informada não é um número válido.");
                return 0;
            }
            if (idade < 0)
            {
                Console.WriteLine("A idade informada não pode ser negativa.");
                return 0;
            }
            try
            {
                Console.Write("Entre com a idade de aposentadoria: ");
                idadeAposentadoria = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("A idade de aposentadoria informada não é um número válido.");
                return 0;
            }
            if (idadeAposentadoria < 0)
            {
                Console.WriteLine("A idade de aposentadoria informada não pode ser negativa.");
                return 0;
            }
            else if(idadeAposentadoria < idade)
            {
                Console.WriteLine("A idade de aposentadoria informada não pode ser menor que a sua idade atual.");
                return 0;
            }
            try
            {
                Console.Write("Entre com o valor mensal que você deseja guardar: R$");
                valorMensal = float.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("O valor mensal informado não é um número válido.");
                return 0;
            }
            if (valorMensal < 0)
            {
                Console.WriteLine("O valor mensal informado não pode ser negativo.");
                return 0;
            }
            try
            {
                Console.Write("Entre com a taxa de rendimento mensal (porcentagem): ");
                taxaRendimento = float.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("A taxa de rendimento informada não é um número válido.");
                return 0;
            }
            if (taxaRendimento < 0)
            {
                Console.WriteLine("A taxa de rendimento informada não pode ser negativa.");
                return 0;
            }
            
            for(int i = 0; i < (idadeAposentadoria - idade) * 12; i++)
            {
                valorTotal += valorMensal;
                valorTotal *= (1 + taxaRendimento / 100);
            }

            Console.WriteLine($"Após {idadeAposentadoria - idade} anos, você terá R${valorTotal:F2} guardados.");
            Console.WriteLine($"Com esse valor, você sua renda será {valorTotal * (taxaRendimento / 100):F2}");
            return valorTotal;
        }
    }
}
