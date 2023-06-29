using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using ex02;
using System.Globalization;
using System.Collections;

namespace Ex01
{
    class Aluguel
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.WriteLine("how many employees will be registered");
            int n = int.Parse(Console.ReadLine());

           

            for (int i = 1; i-1 < n; i++)
            {
                int id;
                Console.Write("Employee "+i+"#");
                Console.WriteLine("");
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.WriteLine("");
                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase :");
            int searchId = int.Parse(Console.ReadLine());
            Employee emp = list.Find(x=> x.Id == searchId);


            if (emp != null)
            {
                Console.Write("Enter the porcentage: ");
                double porc = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.IncreaseSalary(porc);
            }
            else
            {
                Console.WriteLine(" This id does not exist!");
                Console.WriteLine(emp);
            }
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
            
        }

    }
}
       