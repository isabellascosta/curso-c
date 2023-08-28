using System.Collections.Generic;
using Func.Entities;
using System.Linq;

namespace LambdaDelegatesLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Func<Product, string> func = p => p.Name.ToUpper();
            List<string> result = list.Select( p => p.Name.ToUpper()).ToList();

            foreach(string p in result)
            {
                Console.WriteLine(p);
            }
        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
