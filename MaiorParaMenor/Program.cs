using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("----------------- Maior e Menor ---------------------"); // Exemplo de saída

        Console.WriteLine("Informe um número: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe outro número: ");
        int b = int.Parse(Console.ReadLine());

        int diferença = a - b;

        Console.WriteLine($"A diferença dos dois de {a} e {b} é de {diferença}");
    }
}
