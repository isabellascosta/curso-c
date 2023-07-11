using System;
using HerancaPolimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.1));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.00));
            list.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.00, 500.00));

            double sum = 0.0;
            foreach (Account acc in list) {
                sum += acc.Balance;
            }
            Console.WriteLine("total balance: "+sum.ToString("f2",CultureInfo.InvariantCulture));

            foreach(Account acc in list)
            {
                acc.WithDraw(10.0);
            }
            foreach(Account acc in list) 
            {
                Console.WriteLine("updated balance for account"+acc.Number+": "+acc.Balance.ToString("f2",CultureInfo.InvariantCulture));
            }
        }
    }
}