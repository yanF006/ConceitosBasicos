using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalcularParcelas
    {
        int numParcelas;
        float valorVeiculo;
        float valorParcelas;
        float taxaJuros;
        float valorTotal;


        public float parcelar()
        {
            valorTotal = 0;

            try
            {
                Console.Write("Entre com o valor do veículo: R$");
                valorVeiculo = float.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("O valor informado não é um número válido.");
                return 0;
            }

            if(valorVeiculo < 0)
            {
                Console.WriteLine("O valor informado não pode ser negativo.");
                return 0;
            }

            try
            {
                Console.Write("Entre com o número de parcelas: ");
                numParcelas = int.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("O número de parcelas informado não é um número válido.");
                return 0;
            }

            if(numParcelas < 0)
            {
                Console.WriteLine("O número de parcelas informado não pode ser negativo.");
                return 0;
            }

            try
            {
                Console.Write("Entre com a taxa de juros mensal (porcentagem): ");
                taxaJuros = float.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("A taxa de juros informada não é um número válido.");
                return 0;
            }

            if (taxaJuros < 0)
            {
                Console.WriteLine("A taxa de juros informada não pode ser negativa.");
                return 0;
            }

            valorParcelas = (valorVeiculo / numParcelas);

            for (int i = 1; i <= numParcelas; i++)
            {
                valorTotal += valorParcelas;
                valorParcelas *= (1 + taxaJuros / 100);
            }

            Console.WriteLine($"Valor total do carro: R${valorTotal}");
            return valorTotal;
        }
    }
}
