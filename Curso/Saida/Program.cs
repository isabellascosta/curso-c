using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa noite");
            Console.WriteLine("Boa tarde");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));
            //nossa maquina ta colocado numeros com virgula tipo 1,25 pois é a formatação da lingua brasileira que a maquina utiliza, colocando o culture info ele retira qualquer formatação.
            //Necessario  "using System.Globalization;" para funcionar
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine("------------------------");
            Console.WriteLine(saldo);
            //placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F3} reais", nome, idade, saldo);
            // interpolação
            Console.WriteLine($"{nome} tem {idade} e tem saldo igual a {saldo:f2} R$" );
            Console.WriteLine(nome+"tem"+ idade+"anos e tem saldo igual a "+saldo.ToString("F2", CultureInfo.InvariantCulture)+" reais");
        }
    }
}