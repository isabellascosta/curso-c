using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo usado para declarar falso ou verdadeiro
            bool completo = false;
            Console.WriteLine(completo);

            //Caractere 
            char genero = 'F';
            Console.WriteLine(genero);

            //para declarar unicodes use '\u' antes do código
            char letra = '\u0041';
            Console.WriteLine(letra);

            //capacidade até 126
            byte n1 = 126;
            Console.WriteLine(n1);

            int n2 = 1000;
            Console.WriteLine(n2);

            //numeros longos tbm mas nem tanto
            int n3 = 2147483647;
            Console.WriteLine(n3);

            //numeros longos
            long n4 = 2147483648L;
            Console.WriteLine(n4);

            //numeros quebrados, obrigatóriamente tem que por um f no fim do numero
            float n5 = 4.5f;
            Console.WriteLine(n5);

            //pode por somente o numero quebrado
            double n6 = 4.5;
            Console.WriteLine(n6);

            //variavel para texto/frase. É UMA VARIAVEL IMUTAVEL, UMA VEZ CRIADA VOCÊ NÃO PODE ALTERAR O VALOR DELA!
            string nome = "Maria Green";
            Console.WriteLine(nome);

            // aceita numeros e letras
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int dadosmin = int.MinValue;
            int dadosmax = int.MaxValue;
            sbyte minsby = sbyte.MinValue;
            sbyte maxsby = sbyte.MaxValue;
            decimal mindeci = decimal.MinValue;
            decimal maxdeci = decimal.MaxValue;
            Console.WriteLine(maxdeci);
            Console.WriteLine(mindeci);
            Console.WriteLine(maxsby);
            Console.WriteLine(minsby);
            Console.WriteLine(dadosmin);
            Console.WriteLine(dadosmax);


        }
    }
}

