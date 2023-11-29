using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("----------------- Valida valores --------------"); // Exemplo de saída

        Console.WriteLine("Informe um valor: ");
        int num = int.Parse(Console.ReadLine());

        

        if (num >= 0 && num <= 9) {
            Console.WriteLine("Valor válido!");
        }

        else
        {
            Console.WriteLine("Valor inválido!");
        }

    }
}
