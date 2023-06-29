using System;
using System.Xml;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros você vai digitar?");
             int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1;i<=n; i++)
            {
                Console.Write("Valor #"+i+": ");
                int valor = int.Parse(Console.ReadLine());
                
                soma =soma+ valor;

            }
            Console.WriteLine($"Soma = {soma}");
        }
    }
}