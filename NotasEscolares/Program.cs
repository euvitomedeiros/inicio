using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-------------- Notas Escolares --------------------"); // Exemplo de saída

        double notaRP = 0;

        Console.WriteLine("Informe a primeira nota: ");
        double nota1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota: ");
        double nota2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a terceira nota: ");
        double nota3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a quarta nota: ");
        double nota4 = int.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / 4;

        if(media >= 7)
        {
            Console.WriteLine($"Sua média foi de {media:F2}.Parabéns! Você está aprovado!");
        } 
        
        if (media < 7) {

          Console.WriteLine("Favor insira sua nota de recuperação: ");
            notaRP = int.Parse(Console.ReadLine());

            double novaMedia = (notaRP + media) / 2;

            if (novaMedia >= 7)
            {

                Console.WriteLine($"Sua nota foi {novaMedia:F2}, você foi aprovado por recuperação!");
            }
            else
            {
                Console.WriteLine($"Sua nota foi de {novaMedia:F2} então infelizmente foi reprovado.");
            }
        }

        


    }

}
