using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Vamos galera mulheres ---");

            int sim = 1;
            int claro = 2;

            Console.WriteLine("Você quer ser uma dev?\n1. Sim ou 2. Claro");
            int resposta = int.Parse(Console.ReadLine());

            if (resposta == 1)
            {
                Console.WriteLine("Não há força maior do que uma mulher que decide crescer. Vamos galera mulheres!\n#CodingGirl!");
            } else if (resposta == 2) 
            {
                Console.WriteLine("Vamos codar galera mulheres!\n#CodingGirl!");
            } else
            {
                Console.WriteLine("Insira uma opção válida.");
            }

            Console.ReadLine();
        }
    }
}
