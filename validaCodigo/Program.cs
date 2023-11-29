using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--------------- Valida Código -------------------"); // Exemplo de saída

        Console.WriteLine("Informe o código: ");
        int codigo = int.Parse(Console.ReadLine());

        switch (codigo)
        {
            case 1: 
                Console.WriteLine("Um");
                break;
            case 2:
                Console.WriteLine("Dois");
                break;
            case 3:
                Console.WriteLine("Três");
                break;          
        }

        if (codigo > 3)
            Console.WriteLine("código inválido");
        
    }
}
