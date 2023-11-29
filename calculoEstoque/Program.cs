using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade máxima de capacidade do estoque: ");
        int quantidadeMaxima = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade mínima para manter o estoque: ");
        int quantidadeMinima = int.Parse(Console.ReadLine());

        int estoqueMedio = (quantidadeMaxima + quantidadeMinima) / 2;

        Console.WriteLine("A média de capacidade é: "+ estoqueMedio);

    }
}
