using System;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace GenericsSetDicionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0,2,4,5,6,8,10};
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
            PrintColletions(a);
            //união, sempre retorna os dados ordenados
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintColletions(c);

            //intercecão, vai mostrar os itens que tem nas duas listas
            SortedSet<int> d= new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintColletions(d);

            //diferença de conjuntos, vai mostrar os itens que só tem na tabela a

            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintColletions(e);
        }
        static void PrintColletions<T>(IEnumerable<T> colletions)
        {
            foreach (T obj in colletions)
            {
                Console.Write(obj+" ");
               
            }
            Console.WriteLine();

        }
        public void EstudandoHashSet()
        {
            HashSet<string> set = new HashSet<string>();
            //adicionando dados dentro do hash
            set.Add("Tv");
            set.Add("Notebook");
            set.Add("Tablet");
            //verificando se dentro do hash temmos a palavra notebook, retorna bool, tem que escrever direitinho
            Console.WriteLine(set.Contains("notebook"));
            foreach (string p in set)
            {
                Console.WriteLine(p);
            }

        }
    }
}