using System;
using System.Linq;


namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //fazer um programa que cria uma base de dados, e coloca esses dados em outra base onde só pode haver numeros pares, esses numeros serão multiplados por 10

            //especificar o data source
            int[] number = { 2, 3, 4, 5,6,7,8,9,10 };
            //definir a expressão de consulta
            //var result é minha variavel 
            // number.Where(x => x % 2 == 0) number (base de dados) onde(filtrar a base) x => (TAL QUE) X %2 (x mod 2) seja igual a 0, para pegar numeros pares
            // Select(x => x * 10); SELECT (seleciona cada elemento do vetor) x => (tal que) x * 10;
            IEnumerable<int> result = number.Where(x => x % 2 == 0).Select(x => x * 10);

            //executar a consulta
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}
   