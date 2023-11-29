using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("------------ Vai vagabundo --------------"); // Exemplo de saída

        Console.WriteLine("Informe um número: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0) 
        {
            int a = num;

            Console.WriteLine($" Número positivo está na Variavel a = {a}");
        }
        else
        {
            int b = num;
            Console.WriteLine($" Número negativo está na Variavel b = {b}");
        }
    }
}
