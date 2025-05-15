using Aula01._1bim;
using System.Runtime.InteropServices;

while(true)
{
    int opcao;
    Console.WriteLine("0 - Sair");
    Console.WriteLine("1 - Idade");
    Console.WriteLine("10 - Imposto de Renda");
    opcao = int.Parse(Console.ReadLine());
}

/*float salario = float.Parse(Console.ReadLine());
float porcentagem = int.Parse(Console.ReadLine());
CalculaAumento aumento = new CalculaAumento();
aumento.Aumentar(salario, porcentagem);
Console.WriteLine($"Salario inicial: R${aumento.salarioInicial}\nSalario final: R${aumento.salarioFinal}\nAumento: R${aumento.aumento}\nPorcentagem: {aumento.porcentagem}%");*/

/*int metros = int.Parse(Console.ReadLine());
MetrosMilimetros milimetros = new MetrosMilimetros();
Console.WriteLine(milimetros.Milimetros(metros));*/

/*SomaDoisNumeros soma = new SomaDoisNumeros();
Console.WriteLine(soma.Somar(2, 3));*/

/*
Console.WriteLine("Hello, World!");
Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Seja bem-vindo(a) {nome}");
Console.WriteLine("Informe sua idade: ");
try
{
    int idade = int.Parse(Console.ReadLine());
    if ( idade == 0 )
    {
        throw new DuvidaMatematica02Exception();
    }
    if ( idade == 1)
    {
        throw new DuvidaMatematicaException();
    }
    Console.WriteLine("A idade informada foi " + idade);
    if (idade % 2 == 0)
    {
        Console.WriteLine("A idade informada corresponde a um número par!");
    }
    else
    {
        Console.WriteLine("A idade informada corresponde a um número ímpar!");
    }
    string primo = "";
    for (int i = 2; i <= idade / 2; i++)
    {
        if (idade % i == 0)
        {
            primo = "não ";
            break;
        }
    }
    Console.WriteLine($"A idade {primo} corresponde a um número primo");
}
catch(FormatException e)
{
    Console.WriteLine("A idade digitada não corresponde a um número inteiro");
}

catch(DuvidaMatematicaException e)
{
    Console.WriteLine("Não se sabe se um é primo ou não!");
}
catch(Exception e)
{
    Console.WriteLine("Ocorreu um erro desconhecido, contate o desenvolvedor.");
}
*/
