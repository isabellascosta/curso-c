using System;
using System.Collections.Generic;
using System.Globalization;
using Ex02.Entities;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i =1; i<=n; i++)
            {
                Console.WriteLine($"Tax payer {i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char resp = char.Parse(Console.ReadLine());
                if (resp == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditure));
                }
                else if (resp == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of Employess: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAX PAID");
            double sum = 0;
            foreach (TaxPayer tax in list)
            {
                Console.WriteLine(tax.name + ": $" + tax.Tax().ToString("f2", CultureInfo.InvariantCulture));
            }
            foreach (TaxPayer tax in list)
            {
                sum += tax.Tax();
            }
            Console.WriteLine("Total: "+sum.ToString("f2",CultureInfo.InvariantCulture));

        }
    }
}
