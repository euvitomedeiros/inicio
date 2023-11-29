using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.WriteLine("----------- Ordem Crescente ----------"); // Exemplo de saída

        Console.WriteLine("Informe o primeiro valor: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o terceiro valor: ");
        int num3 = int.Parse(Console.ReadLine());



        if(num3 > num1)
    {
            if (num1 > num2)
            {
                Console.WriteLine($"A ordem crescente: {num2}, {num1}, {num3}"); 
            }
            else
            {
                if (num2 < num3)
                {
                    Console.WriteLine($"A ordem crescente: {num1}, {num2}, {num3}");
                }
            }
        }

        if (num1 > num2)
        {
            if (num2 > num3)
            {
                Console.WriteLine($"A ordem crescente: {num3}, {num2}, {num1}");
            }
            else
            {
                if (num3 < num1)
                {
                    Console.WriteLine($"A ordem crescente: {num2}, {num3}, {num1}");
                }
            }
        }

        if (num1 < num2)
        {
            if (num3 < num1)
            {
                Console.WriteLine($"A ordem crescente: {num3}, {num1}, {num2}");
            }
            else
            {
                if (num3 < num2)
                {
                    Console.WriteLine($"A ordem crescente: {num1}, {num3}, {num2}");
                }
            }

        }


    }
}
