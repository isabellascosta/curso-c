using System;
using System.Collections.Generic;
using System.ComponentModel;
using Delegate_action.Entities;


namespace LambdaDelegatesLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //posso criar um objeto do tipo delegate action utilizando uma expressão lambda {} o abre e fecha chaves é para indicar que a função é void
            Action<Product> act = p => { p.Price += p.Price * 0.1; };
            //também é possivel por dentro do foreach a espressão lambda diretamente
            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }


        }
        //posso fazer um metodo action
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

    }

}