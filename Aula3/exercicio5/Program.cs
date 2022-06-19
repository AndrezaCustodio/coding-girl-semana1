using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioNovo;
            double ganho;

            Console.WriteLine("Entre com o seu salário:");
            double salarioAtual = Convert.ToDouble(Console.ReadLine());


            if (salarioAtual == 0 || salarioAtual <= 400.00)
            {
                salarioNovo = salarioAtual + (0.15 * salarioAtual);
                ganho = salarioNovo - salarioAtual;

                Console.WriteLine($"Novo salario: {salarioNovo.ToString("F")} - Reajuste ganho: {ganho} - Em percentual: 15%");
            }
            else if (salarioAtual == 400.01 || salarioAtual <= 800.00)
            {
                salarioNovo = salarioAtual + (0.12 * salarioAtual);
                ganho = salarioNovo - salarioAtual;

                Console.WriteLine($"Novo salario: {salarioNovo.ToString("F")} - Reajuste ganho: {ganho} - Em percentual: 12%");
            }
            else if (salarioAtual == 800.01 && salarioAtual <= 1200.00)
            {
                salarioNovo = salarioAtual + (0.10 * salarioAtual);
                ganho = salarioNovo - salarioAtual;

                Console.WriteLine($"Novo salario: {salarioNovo.ToString("F")} - Reajuste ganho: {ganho.ToString("F")} - Em percentual: 10%");
            }
            else if (salarioAtual == 1200.01 || salarioAtual <= 2000.00)
            {
                salarioNovo = salarioAtual + (0.07 * salarioAtual);
                ganho = salarioNovo - salarioAtual;

                Console.WriteLine($"Novo salario: {salarioNovo.ToString("F")} - Reajuste ganho: {ganho.ToString("F")} - Em percentual: 7%");
            }
            else
            {
                salarioNovo = salarioAtual + (0.04 * salarioAtual);
                ganho = salarioNovo - salarioAtual;

                Console.WriteLine($"Novo salario: {salarioNovo.ToString("F")} - Reajuste ganho: {ganho.ToString("F")} - Em percentual: 4%");
            }

            Console.ReadLine();
        }
    }
}
