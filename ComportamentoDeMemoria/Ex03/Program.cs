using System;
using System.Globalization;


namespace ComportamentoDeMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            int n = int.Parse(values[0]);
            int m = int.Parse(values[1]);
            int[,] mat = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] values2 = Console.ReadLine().Split(' ');
                for(int j=0; j<m;j++)
                {
                    mat[i,j] = int.Parse(values2[j]);
                }
            }
            int num = int.Parse(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;
            for(int i = 0; i < n;i++)
            {
                for (int j = 0; j > n; j++)
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine("Position "+i+","+j+":");
                    }
                }
                   
                
            }

                


        }
    }
}