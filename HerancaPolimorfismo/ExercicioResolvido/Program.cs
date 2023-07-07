using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using ExercicioResolvido.Entities;
using System.Globalization;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)?: ");
                char ch =char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hour: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour:");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Addicional charge: ");
                    double addicionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, addicionalCharge));
                    
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + "- $" + emp.Payment().ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}