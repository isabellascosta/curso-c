using System;
using System.Xml.Linq;
using System.Globalization;
using System.Xml;
using Ex02;

namespace POO
{
    class program
    {
        static void Main(string[] args)
        {
            Cotacao cot = new Cotacao();
            Console.Write("Qual é a cotação do Dolar? ");
            double cota = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos Dolares você vai comprar? ");
            double valorgasto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double valorapagar = Cotacao.Conversao(cota, valorgasto);

            Console.WriteLine("Valor a ser pago em reais= "+valorapagar.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
