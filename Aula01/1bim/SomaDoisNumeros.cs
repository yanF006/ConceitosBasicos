using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    internal class SomaDoisNumeros
    {
        int a, b;
        public void Somar()
        {
            try
            {
                Console.WriteLine("Qual o primeiro valor para somar? ");
                a = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Valor inválido");
                return;
            }
            try
            {
                Console.WriteLine("Qual o segundo valor? ");
                b = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Valor inválido");
                return;
            }
            Console.WriteLine($"O resultado da soma é " + (a+b));
        }
    }
}