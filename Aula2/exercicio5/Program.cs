using System;
using System.Text;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor em real: ");
          float real = float.Parse(Console.ReadLine());

            float dolar = real / 4.87f;
            float euro = real / 5.21f;
            float libra = real / 6.13f;
            float canadianDollar = real / 3.89f;
            float argentinianPeso = real / 0.040f;
            float chileanPeso = real / 0.0059f;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Dólar: US$ {dolar:00.00}\nEuro: € {euro:00.00}\nLibra: £ {libra:00.00}\nDólar Canadense: CAD {canadianDollar:00.00}\nPeso Argentino: ARS {argentinianPeso:00.00}\nPeso Chileno CLP {chileanPeso:00.00}");
            Console.ReadLine();
        }
    }
}
