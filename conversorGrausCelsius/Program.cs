using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("---------------------- Conversor para Graus Celsius ----------------------");

        Console.WriteLine("Informe a temperatura em ºF: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine($"A temperatura em graus Celsius é de {celsius} ºC ");



    }
}
