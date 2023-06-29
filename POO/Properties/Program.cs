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

            Produto p = new Produto("TV", 500.00, 10);
            p.Nome="T";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}