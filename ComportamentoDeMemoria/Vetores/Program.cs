using System;
using System.Globalization;
using System.Net.WebSockets;
using Vetores;

namespace ComportamentoDeMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a quantidade de produtos");
            int n = int. Parse(Console.ReadLine());
            Produto[] vet = new Produto[n];

            for(int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vet[i]  = new Produto {Nome = nome, Preco=preco}; 
            }
            double soma = 0.0;
            for(int i = 0; i < n; i++)
            {
                soma += vet[i].Preco;
            }
            double avg = soma / n;
            Console.WriteLine("Media dos preços= "+avg.ToString("f2",CultureInfo.InvariantCulture));

        }
        public void PrimeirosVetores()
        {
            Console.WriteLine("Escreva a quantidade de numeros de alturas");
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i];
            }
            double avg = soma / n;
            Console.WriteLine("Altura media igual: " + avg.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}