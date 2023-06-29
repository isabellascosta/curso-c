using System;
using System.Net.Http.Headers;
using System.Xml;
using System.Globalization;
using System.ComponentModel;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            //menor que 
            bool c2 = a < 20;
            bool c1 = a < 10;
            //maior que
            bool c3 = a > 10;
            bool c4 = a > 5;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("--------------");
            //menor ou igual a
            bool c5 = a <= 10;
            //maior ou igual a 
            bool c6 = a >= 10;
            //é igual a 
            bool c7 = a == 10;
            //diferente de
            bool c8 = a != 10;
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);

        }
    }
}
