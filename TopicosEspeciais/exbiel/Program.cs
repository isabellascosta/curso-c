using System;
using System.Globalization;
namespace TopicosEspeciais
{
    class program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Digite um numero:");
                string n = Console.ReadLine();
                if (n.Length == 4)
                {
                    Console.WriteLine("unidades: "+n.Substring(3));
                    Console.WriteLine("dezenas: "+n.Substring(2,1));
                    Console.WriteLine("centenas: "+n.Substring(1,1));
                    Console.WriteLine("Milhar: "+n.Substring(0,1));
                }
                else if(n.Length == 3)
                {
                    Console.WriteLine("unidades: " + n.Substring(2));
                    Console.WriteLine("dezenas: " + n.Substring(1,1));
                    Console.WriteLine("centenas: " + n.Substring(0,1));
                    Console.WriteLine("Milhar: " + n.Replace(n,"0"));
                }
                else if (n.Length == 2)
                {
                    Console.WriteLine("unidades: " + n.Substring(1));
                    Console.WriteLine("dezenas: " + n.Substring(0, 1));
                    Console.WriteLine("centenas: " + n.Replace(n, "0"));
                    Console.WriteLine("Milhar: " + n.Replace(n, "0"));
                }
                else if (n.Length == 1)
                {
                    Console.WriteLine("unidades: " + n.Substring(0,1));
                    Console.WriteLine("dezenas: " + n.Replace(n, "0"));
                    Console.WriteLine("centenas: " + n.Replace(n, "0"));
                    Console.WriteLine("Milhar: " + n.Replace(n, "0"));
                }




        }
    }
}