using System;
using System.Xml.Linq;
using System.Globalization;
using System.Xml;
using Private;

namespace POO
{
    class program
    {
        static void Main(string[] args)
        {
            //Primeira implementação manual dede encapsulamento

            Produto p = new Produto("TV",500.00,10);
            Console.WriteLine(p.GetNome());
            p.SetNome("TV 4k");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}
