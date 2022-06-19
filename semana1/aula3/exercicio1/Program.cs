using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int notaCem = 0;
            int notaCinq = 0;
            int notaVinte = 0;
            int notaDez = 0;
            int notaCinco = 0;
            int notaDois = 0;

            Console.WriteLine("Digite o valor monetário: ");
            double total = Convert.ToDouble(Console.ReadLine());


            while (total >= 100.00)
            {
                total = total - 100.00;
                notaCem += 1;
            }
            while (total >= 50.00)
            {
                total = total - 50.00;
                notaCinq += 1;
            }
            while (total >= 20.00)
            {
                total = total - 20.00;
                notaVinte += 1;
            }
            while (total >= 10.00)
            {
                total = total - 10.00;
                notaDez += 1;
            }
            while (total >= 5.00)
            {
                total = total - 5.00;
                notaCinco += 1;
            }
            while (total >= 2.00)
            {
                total = total - 2.00;
                notaDois += 1;
            }


            Console.WriteLine($"Quantidade nota de R$ 100: {notaCem}");
            Console.WriteLine($"Quantidade nota de 50: {notaCinq}");
            Console.WriteLine($"Quantidade nota de 20: {notaVinte}");
            Console.WriteLine($"Quantidade nota de 10: {notaDez}");
            Console.WriteLine($"Quantidade nota de 5: {notaCinco}");
            Console.WriteLine($"Quantidade nota de 2: {notaDois}");
            Console.ReadLine();
        }
    }
}
