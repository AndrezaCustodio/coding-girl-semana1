using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor 1:");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor 2:");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor 3:");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine($"O maior é: {valor1}");
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                Console.WriteLine($"O maior é: {valor2}");
            }
            else
            {
                Console.WriteLine($"O maior é: {valor3}");
            }
            Console.ReadLine();
        }
    }
}
