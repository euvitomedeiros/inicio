using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("------------- Medida de Combustível --------------------");

        Console.WriteLine("Tempo gasto de viagem: ");
        double tempo = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a velocidade média: ");
        double velocidadeMedia = double.Parse(Console.ReadLine());

        double distancia = tempo * velocidadeMedia;

        double litrosUsados = distancia / 12;

        Console.WriteLine($"Velocidade Média {velocidadeMedia}");

        Console.WriteLine($"Tempo gasto de {tempo} horas");

        Console.WriteLine($"A distância percorrida foi de {distancia}, e a quantidade combustível gasto foi de  {litrosUsados:F2} litros");
    }
}
