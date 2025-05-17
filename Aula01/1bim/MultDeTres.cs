using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    internal class MultDeTres
    {
        public void multiplosdetres()
        {
            for (int i = 1; i * 3 < 100; i++)
            {
                Console.WriteLine($"" + i * 3);
            }
        }
    }
}
