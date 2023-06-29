using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Globalization;
using System.Diagnostics.Contracts;
using System.ComponentModel;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva sua senha");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine(" ");
                Console.WriteLine("Escreva sua senha");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");

        }
        public void EscrevaSenha()
        {

        }
        public void Quadrantes()
        {
            Console.WriteLine("Escreva x e y");
            string[] vet = Console.ReadLine().Split(' ');

            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while (x != 0 && y != 0)
            {
                if (x >= 0.00 && y >= 0)
                {
                    Console.WriteLine("Primeiro quadrante");

                }
                else if (x <= 0.00 && y >= 0)
                {
                    Console.WriteLine("Segundo quadrante");

                }

                else if (x <= 0.00 && y <= 0)
                {
                    Console.WriteLine("terceiro quadrante");
                }

                else if (x >= 0.00 && y <= 0)
                {
                    Console.WriteLine("Quarto quadrante");

                }
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
        }
        public void Preferencia()
        {
            Console.WriteLine("Escreva o numero");
            int numero = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (numero != 4)
            {
                if (numero == 1)
                {
                    alcool = alcool + 1;

                }
                if (numero == 2)
                {
                    gasolina = gasolina + 1;
                }
                if (numero == 3)
                {
                    diesel = diesel + 1;
                }
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigada!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}