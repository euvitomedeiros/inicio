using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Calcular o módulo
        int modulo = (numero >= 0) ? numero : numero * (-1);

        // Exibir o resultado
        Console.WriteLine($"O módulo de {numero} é {modulo}");
    }
}
