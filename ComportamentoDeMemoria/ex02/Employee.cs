using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Employee
    {
        public int Id {get; set;}
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double porc)
        {
            Salary = Salary+(porc / 100) * Salary;
            
        }
        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
