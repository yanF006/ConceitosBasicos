using System.Runtime.InteropServices;
using Aula01._1bim;

while (true)
{
    try
    {
        int opcao;

        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("0.\tSair");
        Console.WriteLine("1.\tIdade");
        Console.WriteLine("6.\tIMC");
        Console.WriteLine("7.\tTabuadas");
        Console.WriteLine("8.\tMúltiplos de 3 entre 0 e 10");
        Console.WriteLine("9.\tFatoriais de 0 até 10");
        Console.WriteLine("10.\tImposto de Renda");
        Console.WriteLine("11.\tAdivinhar Número");


        Console.Write("--> ");
        opcao = int.Parse(Console.ReadLine());

        if (opcao == 0) break;

        switch (opcao)
        {
            case 6:
                CalcularIMC calcularIMC = new CalcularIMC();
                calcularIMC.IMC();
                break;
            case 7:
                TabuadaNumero tabuadaNumero = new TabuadaNumero();
                tabuadaNumero.tabuador();
                break;
            case 8:
                MultDeTres multDeTres = new MultDeTres();
                multDeTres.multiplosdetres();
                break;
            case 9:
                FatoriaisZeroADez fatoriaisZeroADez = new FatoriaisZeroADez();
                fatoriaisZeroADez.fatoriais();
                break;
            case 10:
                ImpostoDeRenda impostoDeRenda = new ImpostoDeRenda();
                impostoDeRenda.calcularDeducao();
                break;
            case 11:
                AdivinharNumero adivinharNumero = new AdivinharNumero();
                adivinharNumero.jogar();
                break;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("A opção informada não é um número válido.");
    }
}