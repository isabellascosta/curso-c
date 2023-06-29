using System;
using System.Net.Http.Headers;
using System.Xml;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o Nome Completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');

            string primeironome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2],CultureInfo.InvariantCulture);


            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(primeironome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}