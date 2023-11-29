using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--------------- Comissão para Vendedores --------------------------"); 

        Console.WriteLine("Informe a identificação do Vendedor: ");
        string nomeVendedor = Console.ReadLine();

        Console.WriteLine("Código da peça: ");
        int codPeca = int.Parse(Console.ReadLine());

        Console.WriteLine("Valor unitário: ");
        double valorPeca = double.Parse(Console.ReadLine());

        Console.WriteLine("Quantidade vendida: ");
        int qntdVendido = int.Parse(Console.ReadLine());

        double totalComissao = (qntdVendido * valorPeca) * 0.05;

        Console.WriteLine($"O funcionário {nomeVendedor} irá receber de comissão no valor de R$ {totalComissao:F2}");

      
    }
}
