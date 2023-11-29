using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("------------- Programa Volume da Lata de Azeite --------------------"); // Exemplo de saída

        Console.WriteLine("Informe a altura da lata (cm): ");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o raio da lata (cm): ");
        double raio = double.Parse(Console.ReadLine());

        double volume = 3.14159 * raio * raio * altura;


        Console.WriteLine($"O volume da lata de azeite que você informou tem o total de {volume:F2}");
        
    }
}
