using System;
using System.Net.Http.Headers;
using System.Xml;
using System.Globalization;
using System.ComponentModel;
using System.Numerics;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora >=12 && hora <18)
            {
                Console.WriteLine("boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }
        }
        public void EstruturaComposta()
        {
            Console.WriteLine("entre com um numero");
            int x = int.Parse(Console.ReadLine());

            //Somente if (simples) 
            // if e else (composto)
            //varios if e else (encadeamento)

            if (x % 2 == 0)
            {
                Console.WriteLine("É PAAR");
            }
            else
            {
                Console.WriteLine("É IMPAR");
            }
        }

    }
}