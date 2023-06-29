using System;
using System.Net.Http.Headers;
using System.Xml;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int e = 5;
            e %= 2;
            Console.WriteLine(e);

        }
        private void Operadores()
        {

            //operador += significa que você vai receber a (com o valor já anteriormente existente dele e vai somar mais dois
            int a = 10;
            a += 2;
            Console.WriteLine(a);

            //subtrair
            int b = 10;
            b -= 2;
            Console.WriteLine(b);

            //multiplicar
            int c = 10;
            c *= 2;
            Console.WriteLine(c);

            //dividir
            int d = 10;
            d /= 2;
            Console.WriteLine(d);

            //porcentagem
            int e = 10;
            e %= 2;
            Console.WriteLine(e);

            string amor = "gab";
            Console.WriteLine(amor);

            amor += "riel";
            Console.WriteLine(amor);

            // ++ soma o valor da variavel +1
            int f = 10;
            f++;
            Console.WriteLine(f);

            // -- subtrai o valor da variavel -1
            int g = 10;
            g--;
            Console.WriteLine(g);

            //pedimos para que i recebece h++, com isso h vai ser 11 e i vai ser 10, para que i se torne 11 também use ++ na frente do numero "++h"
            int h = 10;
            int i = h++;
            Console.WriteLine(h);
            Console.WriteLine(i);
        }
        private void Delta()
        {
            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);

            int n3 = 17 % 3;
            Console.WriteLine(n3);

            //compilador entende que você ta querendo dividir dois numeros inteiros quando faz a divisão, então ou você pode usar o casting ou você pode usar o 10.0

            double n4 = (double)10 / 8;
            Console.WriteLine(n4);

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
        }
    }
}