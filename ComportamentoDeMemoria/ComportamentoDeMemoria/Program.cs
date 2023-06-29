using System;
using System.Globalization;


namespace ComportamentoDeMemoria
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Criei uma classe tipo Struct, declarei uma variavel para chamar a classe
            Point P;
            //Mesmo a classe sendo do tipo struct preciso inicializar, para isso posso ou passar valores ou instaciar 
            P.x = 10;
            P.y = 20;
            Console.WriteLine(P);
            P = new Point();
            Console.WriteLine(P);
        }
    }
}