using LambdaDelegatesLinq.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LambdaDelegatesLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV",900.00));
            list.Add(new Product("Notebook",1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Feito uma expressão lambda para fazer o metodo abaixo
            //Comparison<Product> comp = (p1,p2) =>p1.Name.ToUpper().CompareTo(p1.Name.ToUpper());

            //pot fim mostrando que posso usar a expressão diretamente no sort
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p1.Name.ToUpper()));

           

            foreach( Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        //metodo de comparison para  declarar o metodo de referencia ali em cima
        //static int  CompareProducts(Product p1, Product p2)
        //{
          //  return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}
    }
}