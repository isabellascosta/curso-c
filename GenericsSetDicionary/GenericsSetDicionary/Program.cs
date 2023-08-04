using System;
using System.Threading.Channels;
using GenericsSetDicionary.Entities;
namespace GenericsSetDicionary
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("how many values? ");
            int n = int.Parse(Console.ReadLine());


            for(int i = 0; i < n;i++)
            { 
               int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }
            printService.Print();
            Console.Write("Firt: "+printService.First());
        }

    }
}