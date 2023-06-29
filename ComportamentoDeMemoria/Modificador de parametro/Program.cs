using Modificador_de_parametro;
using System;
using System.Globalization;
using System.Net.WebSockets;


namespace ComportamentoDeMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            //como estamos usandp o params usase apenas:
            //Declare o tipo e uma variavel = Classe.Metodo(Parametro[i],paramentro[i]) adendo: como é um vetor passe quantos paramentros quiser
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2,4,3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
