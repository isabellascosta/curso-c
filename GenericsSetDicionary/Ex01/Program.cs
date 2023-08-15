using System;
using System.Linq;
using System.Threading.Channels;


namespace GenericsSetDicionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> courseA = new SortedSet<int>();
            SortedSet<int> courseB = new SortedSet<int>();
            SortedSet<int> courseC = new SortedSet<int>();

            Console.Write("how many students in course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int idA = int.Parse(Console.ReadLine());
                courseA.Add(idA);
            }

            Console.Write("how many students in course B? ");
            int m = int.Parse(Console.ReadLine());
            for (int i = 1; i <= m; i++)
            {
                int idB = int.Parse(Console.ReadLine());
                courseB.Add(idB);
            }
            Console.Write("how many students in course C? ");
            int o = int.Parse(Console.ReadLine());
            for (int i = 1; i <= o; i++)
            {
                int idC = int.Parse(Console.ReadLine());
                courseC.Add(idC);
            }
            courseA.UnionWith(courseB);
            courseA.UnionWith(courseC);
            Console.WriteLine("total de alunos: " + courseA.Count);
        }
    }
}