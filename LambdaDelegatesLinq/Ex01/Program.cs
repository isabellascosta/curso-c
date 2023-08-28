using System;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using Ex01.Entities;

namespace LambdaDelegatesLinq
{
    class program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2],CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }
            Console.Write("Enter salary:");
            double salary1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            var r1 = list.Where(e => e.Salary > salary1).OrderBy(e => e.Email).Select(p => p.Email) ;
            Console.WriteLine("Email of people whose salary is more than 2000.00: ");
            foreach (string r in r1)
            {
                Console.WriteLine(r);
            }
            var r2 = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': "+r2.ToString("f2",CultureInfo.InvariantCulture));



        }

    }
}
