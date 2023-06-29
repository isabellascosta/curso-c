using RefouOut;
using System;
using System.Globalization;
using System.Net.WebSockets;



namespace ComportamentoDeMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            //seguindo  mesm preceito ensinado no metodo Triple, há a necessidade de declarar o ref dentro do paramento onde é passado a variavel também na class program
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            Console.WriteLine("");

            //aqui usamos o out ao inves do ref, então no caso a variavel triple tras a resposta ao inves de ja deixar tudo na mesma variavel
            int b=10;
            int triple;
            Calculator.Triple2(b, out triple);
            Console.WriteLine(triple);

        }
    }
}