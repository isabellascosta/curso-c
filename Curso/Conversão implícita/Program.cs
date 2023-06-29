using System;
using System.Xml;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão. pode ocorrer pois o float tem 4 bytes e o double 8, então cabe. o contrario já não caberia.
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            //casting, estou dizendo de maneira explícita que quero converter o double para float, mas não é recomendado pois pode haver perda de informação.

            double a;
            float b;

            a = 5.1;
            b = (float)a;

            //aqui eu já tive perda de informação pois float aceita numero quebrado e int não aceita.  

            double c;
            int d;

            c = 5.1;
            d = (int)c;
            Console.WriteLine(d);

            int e=5;
            int f=2;
            //casting para que valor não fique cortado já que as variaveis foram declaradas como int
            double resultado = (double) 5 / 2;

            Console.WriteLine(resultado);


        }
    }
}
