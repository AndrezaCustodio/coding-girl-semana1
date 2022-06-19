using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- ano de nascimento e idade ---");
            Console.WriteLine("Digite o ano de nascimento: ");
            int anoNasc = int.Parse(Console.ReadLine());
            int anoAtual = 2022;

            Console.WriteLine($"Sua idade é {anoAtual - anoNasc}");
            Console.ReadLine();
        }
    }
}
