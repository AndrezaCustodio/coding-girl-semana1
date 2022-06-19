using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Você tem {idade} anos, representando {idade * 12} meses ou {idade * 365} dias de idade.");
            Console.ReadLine();
        }
    }
}
