using System;
using System.Threading.Channels;
using Exercitando.Service;
using Exercitando.Entities;
using System.Globalization;

namespace GenericsSetDicionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(",");
                string name = vet[0];
                double price = double.Parse(vet[1], CultureInfo.InvariantCulture);
                list.Add(new Products(name, price));
            }
            Console.WriteLine("Max");
            CalculationService calculationService = new CalculationService();
            Products max = calculationService.Max(list);
            Console.WriteLine(max);

        }
    }
}
