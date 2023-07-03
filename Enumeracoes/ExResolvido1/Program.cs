using ExResolvido1.Entities;
using ExResolvido1.Entities.Enums;
using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter Worker Data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/ MidLevel/ Senior: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name,level,baseSalary,dept);

            Console.Write("how many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());  
            
            for (int i = 1; i-1 < n; i++)
            {
                Console.WriteLine("Enter "+i+"# contract data:");
                Console.Write("Date: (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double ValuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, ValuePerHour, hours);
                worker.AddContract(contract);

            }
            Console.WriteLine("");

            Console.Write("Enter month and year to calculate income (MM/YYYY):");
            string monthandyear = Console.ReadLine();
            int month = int.Parse(monthandyear.Substring(0, 2));
            int year = int.Parse(monthandyear.Substring(3));
            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Department: "+worker.Department.Name);
            Console.WriteLine("income for "+monthandyear+": "+worker.Income(year,month).ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}