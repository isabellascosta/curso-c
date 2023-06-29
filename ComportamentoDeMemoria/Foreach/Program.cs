using System;
using System.Globalization;


namespace ComportamentoDeMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
          

        }
        public void Foreach()
        {
            string[] vet = new string[] { "Maria", "Alex", "bob" };

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.WriteLine("---------------------------");
            foreach (string obj in vet)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
