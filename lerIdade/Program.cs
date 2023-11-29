using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--------------- Ler idade --------------------------"); // Exemplo de saída

        Console.WriteLine("Informe sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        int idadeEmMeses = idade * 12;

        int idadeEmDias = idadeEmMeses * 30;

        Console.WriteLine("Sua idade em meses é de " + idadeEmMeses +" meses e sua idade em dias é de " +  idadeEmDias+ " dias");
    }
}
