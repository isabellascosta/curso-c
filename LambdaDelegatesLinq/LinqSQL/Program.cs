using System;
using System.Globalization;
using System.Linq;
using LinqSQL.Entities;


namespace LinqSQL
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { ID = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { ID = 2, Name = "Computer", Tier = 1 };
            Category c3 = new Category() { ID = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>(){ new Product()
            {ID = 1,Name = "Computer",Price = 1100.00,Category = c2 },
             new Product() {ID = 1,Name = "Computer",Price = 1100.00,Category = c2 },
             new Product() {ID = 2,Name = "Hammer",Price = 90.0,Category = c1 },
             new Product() {ID = 3,Name = "TV",Price = 1300.00,Category = c3 },
             new Product() { ID = 4, Name = "Notebook", Price = 1300.00, Category = c2 },
             new Product() { ID = 5, Name = "Saw", Price = 80.0, Category = c1 },
             new Product() { ID = 6, Name = "Tablet", Price = 700.00, Category = c2 },
             new Product() { ID = 7, Name = "Camera", Price = 700.00, Category = c3 },
             new Product() { ID = 8, Name = "Printer", Price = 350.00, Category = c3 },
             new Product() { ID = 9, Name = "Macbook", Price = 1800.00, Category = c2 },
             new Product() { ID = 10, Name = "Sound Bar", Price = 700.00, Category = c3 },
             new Product() { ID = 11, Name = "Level", Price = 70.00, Category = c1 }
            };
            Console.WriteLine(" ");
            //var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900.00);
            var r1 = from p in products
                     where p.Category.Tier == 1 && p.Price < 900
                     select p;
            Print("Tier 1  and price < 900", r1);


            //var r2 = products.Where(x => x.Category.Name == "Tools").Select(x => x.Name);
            var r2 = from p in products
                     where p.Category.Name == "Tools"
                    select p.Name;
            Print("Names Of Produtcts From tools", r2);


            //var r3 = (products.Where(x => x.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name }));
            var r3 = from p in products
                     where p.Name[0] == 'c'
                     select new
                     {
                         p.Name,
                         p.Price,
                         CategoryName = p.Category.Name
                     };
            Print("Names Started with 'C' and anonymous object ", r3);


            //var r4 = products.Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);
            var r4 = from p in products
                     where p.Category.Tier == 1
                     orderby p.Name
                     orderby p.Price
                     select p ;

            Print("tier 1 order by price", r4);

            var r5 = (from p in r4 
                     select p ).Skip(2).Take(4);
            Print("skip 2 take 4", r5);

            //var r16 = products.GroupBy(p => p.Category);
            var r16 =
                from p in products
                group p by p.Category;
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category: " + group.Key.Name);
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();

            }

        }
    }
}