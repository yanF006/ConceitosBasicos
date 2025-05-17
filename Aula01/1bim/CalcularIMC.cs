using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    internal class CalcularIMC
    {
        float peso;
        float altura;
        float resultadoIMC;

        public void IMC()
        {
            try
            {
                Console.WriteLine("Qual a sua altura? ");
                altura = float.Parse(Console.ReadLine());
            }

            catch (Exception e)
            {
                Console.WriteLine("O peso informado não é um número válido");
                return;
            }

            try
            {
                Console.WriteLine("E qual seu peso? ");
                peso = float.Parse(Console.ReadLine());
            }

            catch (Exception e)
            {
                Console.WriteLine("A altura informada não é um número válido");
                return;
            }
            resultadoIMC = peso / (altura * altura);
            Console.WriteLine($"O seu IMC é: " + resultadoIMC);
            if(resultadoIMC <= 18.5)
            {
                Console.WriteLine("Você está abaixo do peso ideal.");
            }
            else if (resultadoIMC <= 24.9)
            {
                Console.WriteLine("Você está no peso ideal.");
            }
            else if (resultadoIMC <= 29.9)
            {
                Console.WriteLine("Você está com sobrepeso.");
            }
            else if (resultadoIMC <= 34.9)
            {
                Console.WriteLine("Você está com obesidade grau I.");
            }
            else if (resultadoIMC <= 39.9)
            {
                Console.WriteLine("Você está com obesidade grau II.");
            }
            else
            {
                Console.WriteLine("Você está com obesidade grau III.");
            }
        }
    }
}
