using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--------------------- Triâgulo ----------------------"); // Exemplo de saída


        Console.WriteLine("Informe valor para o angulo A: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe valor para o angulo B: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe valor para o angulo C:");
        int c = int.Parse(Console.ReadLine());

        if(a == b && b == c)
        {
            Console.WriteLine("É triângulo equilátero");
        } else if(a == b || a == c || b == c) 
        {
            Console.WriteLine("É triângulo isósceles");
        } else
        {
            Console.WriteLine("É triângulo escaleno");
        }

    }
}
