using System;
using System.Globalization;
using System.Collections.Generic;
using System.Reflection.Metadata;


namespace ComportamentoDeMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>list  = new List<string>();
            //Criando uma lista e adicionando itens na minha lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            //Adicionando com insert um novo item em uma posição especifica
            list.Insert(2, "Marco");

            //Percorrendo o objeto da lista
            foreach (string obj in list) 
            {
                //Imprimindo o os objetos das listas
                Console.WriteLine(obj);
            }

            //Constando os objetos da lista
            Console.WriteLine("List count: "+list.Count);

            //Descobrindo qual objeto do começo da lista começa com a letra A
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro 'A': "+s1);

            // Descobrindo qual objeto do fim da lista começa com a letra A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo 'A': "+s2);

            //Descobrindo a qual numero o  objeto do começo da lista que Começa com A tem
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': "+pos1);
            //Descobrindo a qual numero o objeto
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position 'A': "+pos2);

            //Criando uma nova lista filtro com apenas nomes com mais de 5 catacteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("--------------------------");
            //Removendo um item da lista (Se ele não encontrar o item ele não remove)
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Removendo todos - pede um  Pedricate então passei que é para remover todos os itens que sejam igual a n 
            Console.WriteLine("--------------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------");
            //Usando remove at , basicamente remove pela posição na lista
            list.RemoveAt(1);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------");



        }
        public void Testeslista()
        {
            //Lista vazia já instanciada
            List<string> lista = new List<String>();
            List<string> lista2 = new List<String> { "Maria", "Josefa" };
        }
    }
}