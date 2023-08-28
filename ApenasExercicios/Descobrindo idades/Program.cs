using System;
using System.Globalization;
using System.Net.Http.Headers;
using Descobrindo_idades.Entities;
using Descobrindo_idades.Service;
namespace ApenasExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();
            ServicoDeSaberIdade servico = new ServicoDeSaberIdade();

            Console.Write($"Informe da primeira pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a data de nascimento: ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());
            list.Add(new Pessoa(nome, nascimento));
            Console.Write($"Informe da segunda pessoa: ");
            string nome2 = Console.ReadLine();
            Console.Write("Informe a data de nascimento: ");
            DateTime nascimento2 = DateTime.Parse(Console.ReadLine());
            list.Add(new Pessoa(nome2, nascimento2));

            string result = servico.DescobrindoIdade(nascimento, nascimento2);
            foreach(Pessoa l in list)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("A diferença de idade é de: ");
            Console.WriteLine(result+" dias");




        }
    }
}