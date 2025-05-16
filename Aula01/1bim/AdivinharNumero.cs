using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class AdivinharNumero
    {
        Random aleatorio = new Random();
        int tentativas = 10;
        int palpite;

        public void jogar()
        {
            int numeroAleatorio = aleatorio.Next(0, 101);

            Console.WriteLine("Você tem 10 tentativas para adivinhar um número entre 0 e 100.");
            while (tentativas > 0)
            {
                try
                {
                    Console.Write($"Tentativas restantes: {tentativas}. Digite seu palpite: ");
                    int palpite = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("O palpite informado não é um número válido.");
                    continue;
                }

                if (palpite < numeroAleatorio)
                {
                    Console.WriteLine("O número é maior.");
                }
                else if (palpite > numeroAleatorio)
                {
                    Console.WriteLine("O número é menor.");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você adivinhou o número {numeroAleatorio}!");
                    return;
                }
                tentativas--;
            }
            Console.WriteLine($"Você perdeu! O número era {numeroAleatorio}.");
        }
    }
}
