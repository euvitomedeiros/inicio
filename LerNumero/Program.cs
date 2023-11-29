using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-------------- Ler Numero ------------------"); // Exemplo de saída

        string resposta = "";

        do
        {
            Console.WriteLine("Informe um numero: ");
            int num = int.Parse(Console.ReadLine());

            if(num < 0 )
            {
                Console.WriteLine("Este número é negativo");
            } else
            {
                Console.WriteLine("Este número é positivo");
            }

            Console.WriteLine("Deseja continuar? Sim/Não ");
            resposta = Console.ReadLine();

        } while (resposta == "Sim");
    }
}
