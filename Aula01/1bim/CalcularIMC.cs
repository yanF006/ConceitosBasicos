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
            }

            try
            {
                Console.WriteLine("E qual seu peso? ");
                peso = float.Parse(Console.ReadLine());
            }

            catch (Exception e)
            {
                Console.WriteLine("A altura informada não é um número válido");
            }
            resultadoIMC = peso / (altura * altura);
            Console.WriteLine($"O seu IMC é: " + resultadoIMC);
        }
    }
}
