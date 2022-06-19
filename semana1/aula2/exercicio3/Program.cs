using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hora trabalhada: ");
            int horaTrab = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor da hora: ");
            float valorHora = float.Parse(Console.ReadLine());

            Console.WriteLine($"O funcionário trabalhou {horaTrab} horas\nO salário é R${horaTrab * valorHora:00.00}");
            Console.ReadLine();
        }
    }
}
