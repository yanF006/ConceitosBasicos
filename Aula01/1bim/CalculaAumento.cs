using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalculaAumento
    {
        public float salarioInicial;
        public float salarioFinal;
        public float aumento;
        public float porcentagem;

        public void Aumentar(float s, float p)
        {
            salarioInicial = s;
            porcentagem = p;
            salarioFinal = s * (1 + p / 100);
            aumento = salarioFinal - salarioInicial;
        }
    }
}
