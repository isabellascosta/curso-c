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
            //Segunda aula

            // Como o readLine é uma string, para poder alocar o seu conteúdo em uma variável, é necessário utilizar uma conversão int.Parse 
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(" ");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
        public void EntradaDeDados()
        {
            //Primeira aula
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();


            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine($"você digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}