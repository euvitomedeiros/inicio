using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a cotação do dolar atual: "); 
        double cotacaoDolar = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor em dolares que você possui: ");
        double valorDolar = double.Parse(Console.ReadLine());

        double valorReal = cotacaoDolar * valorDolar;

        Console.WriteLine("O valor em R$ é " +  valorReal);

    }
}
