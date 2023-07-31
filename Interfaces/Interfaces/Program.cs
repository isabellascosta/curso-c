using Microsoft.VisualBasic;
using System;
using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter rental data: ");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);
            Console.Write("return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd//yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start,finish, new Vehicle(model));

            Console.Write("Enter price per hour: ");
            double hour =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            RentalService rentalService = new RentalService(hour, day,new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}