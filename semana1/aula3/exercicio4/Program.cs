using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nota 1:");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 2:");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 3:");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            double media = (valor1 + valor2 + valor3) / 3;

            if (media < 6.0)
            {
                Console.WriteLine($"O Aluno tirou F! Reprovado");
            }
            else if (media >= 6.0 && media < 7.0)
            {
                Console.WriteLine($"{media}, O Aluno tirou D! Reprovado");
            }
            else if (media >= 7.0 && media < 8.0)
            {
                Console.WriteLine($"{media}, O Aluno tirou C! Parabéns");
            }
            else if (media >= 8.0 && media < 9.0)
            {
                Console.WriteLine($"{media}, O Aluno tirou B. Parabéns!");
            }
            else if (media >= 9.0 && media <= 10)
            {
                Console.WriteLine($"{media}, O Aluno tirou A. Parabéns!");
            }
            Console.ReadLine();
        }
    }
}
