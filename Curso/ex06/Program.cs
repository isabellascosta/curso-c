using System;
using System.Xml;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Windows.Markup;
using System.Runtime.Serialization;
using System.Xml.Schema;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o número");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i <=n; i++)
            {
                double valorQuad = Math.Pow(i, 2);
                double ValorCubo = Math.Pow(i, 3);
                Console.WriteLine($"{i}   {valorQuad}     {ValorCubo}");
            }
                
        }
       
        public void NumerosImpares()
        {
            Console.WriteLine("Escreva até que numero quer ler");
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= n; i++)
            {
                double resto = i % 2;
                if (resto != 0)
                {
                    Console.WriteLine($"Os numeros impares são {i}");


                }
            }
        }
        public void InOut()
        {
            Console.WriteLine("Escreva a quantidade de valores que será passado");

            int n = int.Parse(Console.ReadLine());
            int valores = 0;
            int a = 0;
            int b = 0;

            for (int i = 1; i <= n; i++)
            {
                int values = int.Parse(Console.ReadLine());
                valores = values;
                if (valores >= 10.00 && valores <= 20.00)
                {
                    a = a + 1;

                }
                else
                {
                    b = b + 1;
                }
            }
            Console.WriteLine($"Int {a}");
            Console.WriteLine($"Out {b}");
        }
        public void MediaPonderada()
        {
            Console.WriteLine("Passe a quantidade de valores a fazer a conta");
            int n = int.Parse(Console.ReadLine());
            double NP = 0;
            double np1 = 0;
            double np2 = 0;
            double np3 = 0;

            for (int i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double nota1 = Double.Parse(vet[0], CultureInfo.InvariantCulture);
                double nota2 = Double.Parse(vet[1], CultureInfo.InvariantCulture);
                double nota3 = Double.Parse(vet[2], CultureInfo.InvariantCulture);
                if (i == 1)
                {
                    NP = (nota1 * 2 + nota2 * 3 + nota3 * 5) / (2 + 3 + 5);

                    np1 = NP;
                }
                if (i == 2)
                {
                    NP = (nota1 * 2 + nota2 * 3 + nota3 * 5) / (2 + 3 + 5);
                    np2 = NP;
                }
                if (i == 3)
                {
                    NP = (nota1 * 2 + nota2 * 3 + nota3 * 5) / (2 + 3 + 5);
                    np3 = NP;
                }


            }
            Console.WriteLine("A nota é " + np1.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("A nota é " + np2.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("A nota é " + np3.ToString("F1", CultureInfo.InvariantCulture));

        }
        public void fatorial ()
        {
            Console.WriteLine("Escreva o numero fatorial");
            int n = int.Parse(Console.ReadLine());
            int resul = 1;



            for (int i = 1; i <= n; i++)
            {
                resul = resul * i;
            }
            Console.WriteLine(resul);
        }
        public void Resto()
        {
            Console.WriteLine("Escreva o numero");
            double n = double.Parse(Console.ReadLine());
            double resul = 1;
            double conta;
            double resto;
            for (int i = 1; i <= n; i++)
            {
                conta = n / i;
                resto = conta % 2;
                if (n % i == 0)
                {
                    Console.WriteLine(conta);
                }



            }
        }

    }
}