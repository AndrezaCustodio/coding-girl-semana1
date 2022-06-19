using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Digite aqui suas 3 notas");
			double nota1 = double.Parse(Console.ReadLine());
			double nota2 = double.Parse(Console.ReadLine());
			double nota3 = double.Parse(Console.ReadLine());

			double media = (nota1 + nota2 + nota3) / 3;
			Console.WriteLine($"A sua média é {media}");

			if (media >= 7)
			{
				Console.WriteLine($"Você foi aprovado, parabéns!");
			}
			else
			{
				Console.WriteLine($"Você foi reprovado.");
			}
		}
    }
}
