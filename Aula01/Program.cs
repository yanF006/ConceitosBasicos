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
        Console.WriteLine("10.\tImposto de Renda");
        Console.WriteLine("11.\tAdivinhar Número");
        Console.WriteLine("12.\tCalcular Parcelas de Veículo");
        Console.WriteLine("13.\tCalcular Aposentadoria");

        Console.Write("--> ");
        opcao = int.Parse(Console.ReadLine());

        if (opcao == 0) break;

        switch (opcao)
        {
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
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("A opção informada não é um número válido.");
    }
}
