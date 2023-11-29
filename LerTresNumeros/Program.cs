using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--------------- Ler 3 números --------------"); // Exemplo de saída

        int a, b, c;

        do
        {
            Console.WriteLine("Informe valor para A: ");

        } while (!int.TryParse(Console.ReadLine(), out a) || a <= 0);

        do
        {
            Console.WriteLine("Informe valor para B: ");

        } while (!int.TryParse(Console.ReadLine(), out b) || b <= 0);

        do
        {
            Console.WriteLine("Informe valor para C: ");

        } while (!int.TryParse(Console.ReadLine(), out c) || c <= 0);


        int menor = (a < b && a < c) ? a : (b < c) ? b : c;
        int maior = (a > b && a > c) ? a : (b > c) ? b : c;

        
        int resultadoMultiplicacao = menor * maior;
        

        Console.WriteLine("O menor valor multiplicado pelo maior é: " + resultadoMultiplicacao);

        if(menor != 0)
        {
            double resultadoDivisao = maior / menor;
            Console.WriteLine("O maior valor multiplicado pelo menor é: " + resultadoDivisao);

        } else
        {
            Console.WriteLine("Não é possível dividir por 0");
        }



    }
}
