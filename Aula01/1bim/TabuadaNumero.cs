using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    internal class TabuadaNumero
    {
        float numMultiplicar;
        public void tabuador()
        {
            try 
            { 
                Console.WriteLine("Qual tabuada você quer? ");
                numMultiplicar = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Número inserido inválido\n");
            }
            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine($"" + numMultiplicar + " * " + i + " = " + numMultiplicar * i);
            }
        }
    }
}
