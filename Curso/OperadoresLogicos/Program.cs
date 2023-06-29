using System;
using System.Net.Http.Headers;
using System.Xml;
using System.Globalization;
using System.ComponentModel;
using System.Numerics;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            // E = &&     OU = ||    NÃO !

            // 2 é maior do que tres e 4 é diferente de 5
            bool c1 = 2 >3  && 4 != 5; 
            bool c2 = 2 > 3 || 4 != 5;//verdadeiro
            bool c3 = !(2 > 3) && 4 != 5; ;// verdadeiro

            //precedencia ! > && > || 

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine("-------------");
            bool c4 = 10 < 5; //falsa
            bool c5 = c2 || c3 && c4;
            Console.WriteLine(c5);
        }
    }
}