using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class ImpostoDeRenda
    {
        float baseCalculo;
        float valorFinal;
        float deducao;
        int dependentes;

        public float calcularDeducao()
        {
            try
            {
                Console.Write("Informe sua renda: R$");
                baseCalculo = float.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("A renda informada não é um número válido.");
                return 0;
            }

            try
            {
                Console.Write("Informe o número de dependentes: ");
                dependentes = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("O número de dependentes informado não é um número válido.");
                return 0;
            }

            if (dependentes < 0)
            {
                Console.WriteLine("O número de dependentes não pode ser negativo.");
                return 0;
            }

            if (baseCalculo < 0)
            {
                Console.WriteLine("A renda informada não pode ser negativa.");
                return 0;
            }
            else if (baseCalculo <= 1903.98)
            {
                deducao = 0;
                valorFinal = 0;
            }
            else if (baseCalculo <= 2826.65)
            {
                deducao = 142.80f;
                valorFinal = baseCalculo * 0.075f - deducao * dependentes;
            }
            else if (baseCalculo <= 3751.05)
            {
                deducao = 354.80f;
                valorFinal = baseCalculo * 0.15f - deducao * dependentes;
            }
            else if (baseCalculo <= 4664.68)
            {
                deducao = 636.13f;
                valorFinal = baseCalculo * 0.225f - deducao * dependentes;
            }
            else
            {
                deducao = 869.36f;
                valorFinal = baseCalculo * 0.275f - deducao * dependentes;
            }

            Console.WriteLine($"A dedução por dependente é: R${deducao:F2}");
            Console.WriteLine($"O valor total a pagar é: R${valorFinal:F2}");
            Console.WriteLine($"O salário líquido é: R${baseCalculo - valorFinal:F2}");
            return deducao;
        }
    }
}
