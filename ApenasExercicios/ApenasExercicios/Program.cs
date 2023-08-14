using System;
using ApenasExercicios.Entities;
using ApenasExercicios.Services;

namespace ApenasExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoas> list = new List<Pessoas>();
            Console.WriteLine("Insira 3 dados de pessoas diferentes para determinar a mais velha");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Entre com o Nome e Idade: ");
                string[] vet = Console.ReadLine().Split(' ');
                string nome = vet[0];
                int idade = int.Parse(vet[1]);
                list.Add(new Pessoas(nome, idade));
            }

            MaxService maxService = new MaxService();
            Pessoas max = maxService.Max(list);
            Console.WriteLine("Pessoa mais velha");
            Console.WriteLine(max);


        }
    }
}




