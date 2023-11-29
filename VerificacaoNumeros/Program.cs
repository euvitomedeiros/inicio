using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-------------- Verificador de Números -----------------"); // Exemplo de saída

        Console.WriteLine("Informe um número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe outro número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("-------- Selecione as opções ------------\n \n");

        Console.WriteLine("1 - Verificar se um dos números lidos é ou não múltiplo do outro ");
        Console.WriteLine("2 - Verificar se os dois números lidos são pares ");
        Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
        Console.WriteLine("4 - Sair ");
        int op = int.Parse(Console.ReadLine());

        switch (op) {
        
        case 1:
                if(num1 % num2 == 0 ||  num2 % num1 == 0)
                {
                    Console.WriteLine("Eles são multiplos de um e de outro");
                } else
                {
                    Console.WriteLine("Eles não são multiplos entre si.");
                }
                break;
        case 2:

                if(num1 % 2 == 0 && num2 % 2 == 0)
                {
                    Console.WriteLine($"{num1} e {num2} são pares");
                } else if(num1 % 2 == 0 ||  num2 % 2 == 0)
                {
                    Console.WriteLine("Há um número par");
                } else
                {
                    Console.WriteLine("Não há números pares.");
                }
                break;
        case 3:

                int media = (num1 + num2) / 2;

                if(media >= 7) 
                {
                    Console.WriteLine($"A média é {media} e é maior ou igual a 7");
                } else
                {
                    Console.WriteLine($"A média é {media} e é menor que 7");
                }
                break;
        case 4:
                Console.WriteLine("Até logo!");
                break;


        }


    }
}
