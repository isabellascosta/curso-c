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
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            for(int i=0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for(int j=0; j < n;j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Main Diagonal: ");
            for (int i=0; i <n; i++)
            {
                Console.Write(mat[i,i]+" ");
            }   
            Console.WriteLine();
            int count = 0;
            for (int i=0; i <n;i++)
            {
                for (int j=0; j < n; j++)
                {
                    if(mat[i,j]<0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("negative numbers: "+count);
        }
        public void ExplicandoMatriz()
        {
            //criando uma matriz, entre colchetes preciso por uma virgula pra declarar uma matriz, logo depois coloco os dados 2-linhas 3-colunas
            double[,] mat = new double[2, 3];
            //Mat.length significa qua vai mostrar quantos itens tem na matrix  no total
            Console.WriteLine(mat.Length);
            //vai dizer a quantidade de linhas da sua matriz
            Console.WriteLine(mat.Rank);
            //percorrendo a matriz,na dimensão 0 e na primeira dimensão
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));

        }
    }
}