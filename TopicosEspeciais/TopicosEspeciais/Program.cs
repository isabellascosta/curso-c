using System;

namespace TopicosEspeciais
{
    class program
    {
        static void Main(string[] args)
        {
            //forma de declarar variavel sem que haja a necessidade de especificar o tipo da variavel
            var x = 10;
            var y = 20.0;
            var z = "Maria";
            //pode se usar assim mas por ser uma comodidade os programadores poderiam deixar passar alguns erros, o mais recomendado é especificar
            Console.WriteLine(x);
            Console.WriteLine(y);   
            Console.WriteLine(z);
        }
    }
}