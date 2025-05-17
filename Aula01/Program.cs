using System.Runtime.InteropServices;
using Aula01._1bim;

while (true)
{
    try
    {
        int opcao;

        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("0.\tSair");
        Console.WriteLine("1.\tSoma de dois valores");
        Console.WriteLine("2.\tConversão metros para milímetros");
        Console.WriteLine("3.\tAumento de salário");
        Console.WriteLine("4.\tCalculadora de desconto");
        Console.WriteLine("5.\tAluguel de carro");
        Console.WriteLine("6.\tIMC");
        Console.WriteLine("7.\tTabuadas");
        Console.WriteLine("8.\tMúltiplos de 3 entre 0 e 100");
        Console.WriteLine("9.\tFatoriais de 0 até 10");
        Console.WriteLine("10.\tImposto de Renda");
        Console.WriteLine("11.\tAdivinhar Número");
        Console.WriteLine("12.\tFinanciamento de veículo");
        Console.WriteLine("13.\tAposentadoria");


        Console.Write("--> ");
        opcao = int.Parse(Console.ReadLine());

        if (opcao == 0) break;

        switch (opcao)
        {
            case 1:
                SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();
                somaDoisNumeros.Somar();
                break;
            case 2:
                MetrosMilimetros metrosMilimetros = new MetrosMilimetros();
                metrosMilimetros.Milimetros();
                break;
            case 3:
                CalculaAumento aumento = new CalculaAumento();
                aumento.Aumentar();
                break;
            case 4:
                CalcularDesconto calcularDesconto = new CalcularDesconto();
                calcularDesconto.descontador();
                break;
            case 5:
                AluguelCarro aluguelCarro = new AluguelCarro();
                aluguelCarro.alugador();
                break;
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
            case 12:
                CalcularParcelas calcularParcelas = new CalcularParcelas();
                calcularParcelas.parcelar();
                break;
            case 13:
                CalcularAposentadoria calcularAposentadoria = new CalcularAposentadoria();
                calcularAposentadoria.calcularRenda();
                break;
            default:
                Console.WriteLine("Valor inválido");
                break;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("A opção informada não é um número válido.");
    }
}