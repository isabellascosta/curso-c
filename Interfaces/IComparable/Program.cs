using System.Transactions;
using System.Security.Authentication;
using System;
using IComparablestudy.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\teste\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("an error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}