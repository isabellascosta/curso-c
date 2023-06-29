using Ex01;
using System;
using System.Globalization;
using System.Numerics;

namespace ComportamentoDeMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] vet = new Aluguel[10];
            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            for(int i =1; i-1 < n;i++)
            {
                Console.WriteLine("Aluguel "+i+":");
                Console.Write("Nome:" );
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vet[quarto] = new Aluguel ( nome, email );
            }

            Console.WriteLine("");
            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < 10; i++) 
            {
                if (vet[i]!= null)
                {
                    Console.WriteLine(i+": " +vet[i]);
                }
            }







        }
    }
}