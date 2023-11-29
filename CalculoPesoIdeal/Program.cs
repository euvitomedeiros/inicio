using System;

Console.WriteLine("------------- Calculo Peso Ideal -------------------"); // Exemplo de saída

Console.WriteLine("Informe seu sexo: (masculino/feminino)");
string sexo = Console.ReadLine();

Console.WriteLine("Informe sua altura: ");
double altura = double.Parse(Console.ReadLine());

switch (sexo.ToLower())
{

    case "masculino":
        double peso = (72.7 * altura) - 58;

        Console.WriteLine($"Seu peso ideal é {peso:F2}kg");

        break;
    case "feminino":

        peso = (62.1 * altura) - 44.7;

        Console.WriteLine($"Seu peso ideal é {peso:F2}kg");

        break;
}
