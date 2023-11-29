using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("------------ Operadores -----------------"); // Exemplo de saída

        int num1 = 0 , num2 = 0, op, total;

        Console.WriteLine("Informe um valor: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe um outro valor:");
        num2 = int.Parse(Console.ReadLine());


        Console.WriteLine("Agora selecione uma opção de operador: ");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                total = num1 + num2;

                Console.WriteLine("o Total da soma dos valores informado é " + total);

                break;
            case 2:
                total = num1 - num2;

                Console.WriteLine("o Total da subtração dos valores informados é " + total);
                break;
            case 3: 
                total = num1 * num2;

                Console.WriteLine("o Total da multiplicação dos valores informado é " + total);
                break;
            case 4:
                total = num1 / num2;

                Console.WriteLine("o Total da divisão dos valores informado é " + total);
                break;
            case 5:
                Console.WriteLine("Opção errada!");
                break; 

        }
    }
}
