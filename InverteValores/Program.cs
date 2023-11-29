using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("------------------ Inverte valores de varáveis ---------------------"); // Exemplo de saída

        Console.WriteLine("Informe um valor para (A): ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe um valor para (B): ");
        int b = int.Parse(Console.ReadLine()); 

            int temp = a;
            a = b;
            b = temp;

        

        Console.WriteLine($"Valor de A agora é {a} e B agora é {b}");


      }
}
