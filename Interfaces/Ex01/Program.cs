using Microsoft.VisualBasic;
using System;
using System.Globalization;
using Ex01.Entities;
using Ex01.Services;
using System.Transactions;
using System.Security.Authentication;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("contract value: ");
            double amount = double.Parse(Console.ReadLine());
            Contrato contract = new Contrato(number, date, amount);

            Console.Write("Enter number  of installment: ");
            int amountinstall = int.Parse(Console.ReadLine());
            Parcelas installment = new Parcelas(amount);
            Console.WriteLine("installments: ");
            ContratoServico contractService = new ContratoServico(new PaypalServico());
            contractService.ProcessContract(contract, amountinstall);
            
        }
    }
}