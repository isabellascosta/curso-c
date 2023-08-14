using ColecaoHash.Entities;
using System;
using System.Threading.Channels;


namespace GenericsSetDicionary
{
    class Program
    {
        static void Main(string[] args)
        { 
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV",900));
            a.Add(new Product("Notebook", 1200.00));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3,4));
            b.Add(new Point(5,10));
            Product prod = new Product("Notebook", 1200.00);
            //como eu tenho os metodos implementados do get hash code e equals, o a esta comparando por conteudo e não por referencia
            Console.WriteLine(a.Contains(prod));
            Point P = new Point(5,10);
            Console.WriteLine(b.Contains(P));
            
        }
    }
}