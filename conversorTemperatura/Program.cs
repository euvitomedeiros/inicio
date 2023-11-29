using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("------------------ Conversor de Temperatura ------------------------");

        Console.WriteLine("Informe a temperatura em graus Celsius (ºC): ");
        double grausCelsius = double.Parse(Console.ReadLine());

        double fahrenheit = (9 *  grausCelsius + 160) / 5;

        Console.WriteLine($"A temperatura em graus Fahrenheit é de {fahrenheit}ºF graus");
    }
}
