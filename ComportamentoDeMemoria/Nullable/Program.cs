using System;
using System.Globalization;


namespace ComportamentoDeMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;
            // ?? é o operador de coalescência nula, basicamente ele diz que se você já tem um valor alocado na variavel, que o mantenha
            // mas caso não tenha, aloque então o valor após ??
            double a = x ?? 5;
            double b = y ?? 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public void AprendendoNullable()
        {
            // pode ser feito Nullable<double> x = null mas é mais facil por somente uma interrogação depois do tipo, que significa que pode ou não ser nulo
            double? x = null;
            double? y = 10.0;

            //get value or default basicamente diz que você pode pegar  ou o valor alocado na variavel ou se for nulo o valor padrão da variavel
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine("");
            //Has value funciona como um bool, se o item tem valor será um true, se é nulo é um false 
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            Console.WriteLine("");
            //vai criar uma exceção caso você tente usar uma variavel sem valor
            Console.WriteLine(x.Value);
            Console.WriteLine(y.Value);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is Null");
                Console.WriteLine(y.Value);
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
                Console.WriteLine(x.Value);
            }
        }
    }
}
