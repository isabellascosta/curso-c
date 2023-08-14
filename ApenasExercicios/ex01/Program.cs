using ex01.Entities;
using System;
using System.Net.Http.Headers;

namespace ApenasExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o nome da pessoa");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com a data de nascimento (dd/MM/yyyy)");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a altura da pessoa");
            double altura = double.Parse(Console.ReadLine());
            Costumer costum = new Costumer(nome,dataNasc,altura);

            Console.WriteLine(costum);
            Console.Write("idade: ");
            Console.WriteLine(costum.CalculodeIdade(dataNasc));
        }
    }
}