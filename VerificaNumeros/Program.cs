using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("------------ Ler dois números -----------------");


        Console.WriteLine("Informe um número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("informe outro número: ");
        int num2 = int.Parse(Console.ReadLine());

        if(num1 == num2)
        {
            Console.WriteLine("São iguais");
        }
        else
        {
            Console.WriteLine("Não são iguais");
        }

        if (num1 >= num2)
        {
            Console.WriteLine($"{num1} é maior ou igual a {num2}.");
        }
        else
        {
            Console.WriteLine($"{num1} é menor que {num2}.");
        }

        // Verifica os relacionamentos de ordem
        if (num1 <= num2)
        {
            Console.WriteLine($"{num1} é menor ou igual a {num2}.");
        }
        else
        {
            Console.WriteLine($"{num1} é maior que {num2}.");
        }
    }
}
