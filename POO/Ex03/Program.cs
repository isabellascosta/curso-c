using System;
using System.Xml.Linq;
using System.Globalization;
using System.Xml;
using Ex03;

namespace POO
{
    class program
    {
        static void Main(string[] args)
        {
            Banco b = new Banco();
            Console.Write("Entre com o numero da conta: ");
            b.NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");    
            b.NomeTitular= Console.ReadLine();
            Console.Write("Haverá deposito inicial? (s/n)");
            b.DepositoInicial = char.Parse(Console.ReadLine());

            if(b.DepositoInicial == 's' ) 
            {
                Console.Write("Entre com valor de deposito inicial: ");
                b.PrimeiroDeposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(b);
            Console.WriteLine("");

            Console.Write("Entre com um valor para depósito: $");
            b.DepositoComum = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta atualizados: ");
            b.SaldoTotal();
            Console.WriteLine(b);
            Console.WriteLine("");

            Console.Write("Entre com um valor para saque: ");
            b.Saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta atualizados");
            b.SaquedaConta();
            Console.WriteLine(b);

        }
    }
}