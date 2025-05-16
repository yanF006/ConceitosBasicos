using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    internal class FatoriaisZeroADez
    {
        public void fatoriais()
        {
            int j = 1, fatResult = 1;
            for(int i = 1; i < 11; i++)
            {
                j = i;
                while (j > 0)
                {
                    fatResult = fatResult * j;
                    j--;
                }
                Console.WriteLine($"" + fatResult);
                fatResult = 1;
            }
        }
    }
}
