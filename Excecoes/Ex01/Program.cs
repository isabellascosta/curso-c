using Ex01.Entities;
using Ex01.Entities.Exceptions;
using System;
using System.Globalization;
using System.Security.Principal;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account();
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("WithDraw Limit: ");
                double inicialLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("");
                account = new Account(number, holder, balance, inicialLimit);
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.WithDraw(amount);

                Console.WriteLine("New balance: " + account.WithDraw(amount).ToString("f2",CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("WithDraw error: "+e.Message);
            }

        }
        }
    }