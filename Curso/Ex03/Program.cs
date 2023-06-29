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

            double  pi=3.14159;
            Console.WriteLine("Passe o A, B e C");
            string[] vet = Console.ReadLine().Split(' ');

            double a = double.Parse(vet [0]);
            double b = double.Parse( vet [1]);
            double c = double.Parse(vet [2]);
        

            double areatri = a * c / 2;
            double areacir = pi * Math.Pow(c, 2);
            double areatra = ((a + b)* c / 2);
            double areaqua = Math.Pow(b, 2);
            double arearet = a * b;

            Console.WriteLine("TRIANGULO: "+areatri.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areacir.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areatra.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaqua.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + arearet.ToString("f3", CultureInfo.InvariantCulture));


        }

        public void Somar()
        {
            int resultado;
            Console.WriteLine("Escreva o primeiro numero da soma");
            int soma1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo numero da soma");
            int soma2 = int.Parse(Console.ReadLine());

            resultado = soma1 + soma2;
            Console.WriteLine("O resultado da soma é: ");
        }
        public void CirculoCircunferencia()
        {
            double area;
            double pi = 3.14159;
            Console.WriteLine("Escreva o valor da area");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * Math.Pow(raio, 2);
            Console.WriteLine("o valor do raio de um circulo é:" + area.ToString("f4", CultureInfo.InvariantCulture));
        }
        public void Diferenca()
        {
            int a, b, c, d, resultado;

            Console.WriteLine("Entre com valor de A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com valor de B");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com valor de C");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com valor de D");
            d = int.Parse(Console.ReadLine());

            resultado = (a * b - c * d);

            Console.WriteLine($"DIFERENÇA: {resultado}");
        }

        public void HorasTrabalhadas()
        {
                int numerofunc, horastrab;
        double valorhora, resultado;

        Console.WriteLine("Digite o numero do funcionario");
            numerofunc = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite as horas trabalhadas");
            horastrab = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da hora trabalhada");
            valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        resultado = valorhora* horastrab;

        Console.WriteLine("Numero = " + numerofunc);
            Console.WriteLine("Salario = U$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
        public void SistemaLoja()
        {
            Console.WriteLine("Passe o código do produto,numero de peças,valor unitário");
            string[] vet = Console.ReadLine().Split(' ');
            Console.WriteLine("Passe o código do produto,numero de peças,valor unitário");
            string[] vet2 = Console.ReadLine().Split(' ');
            int cdgpc1 = int.Parse(vet[0]);
            int nmrpc1 = int.Parse(vet[1]);
            double vlrpc1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            int cdgpc2 = int.Parse(vet2[0]);
            int nmrpc2 = int.Parse(vet2[1]);
            double vlrpc2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double mult1 = nmrpc1 * vlrpc1;
            double mult2 = nmrpc2 * vlrpc2;

            double resultado = mult1 + mult2;

            Console.WriteLine("Valor a pagar: R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}