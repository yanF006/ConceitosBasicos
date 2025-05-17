using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class MetrosMilimetros
    {
        float metros;
        public void Milimetros()
        {
            try
            {
                Console.WriteLine("Qual o valor em metros? ");
                metros = float.Parse(Console.ReadLine());
            }

            catch (Exception e)
            {
                Console.WriteLine("Número inválido"); 
                return;
            }
            Console.WriteLine($"" + metros + " mm em metros fica " + metros * 1000 + "mm");
        }
    }
}
