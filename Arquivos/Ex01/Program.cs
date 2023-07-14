using Ex01.Entities;
using System;
using System.Globalization;
using System.IO;
using System.Net;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\arquivos\vendas.csv";
            string summary = @"c:\arquivos\out\summary.csv";
            try
            {
                List<Product> list = new List<Product>();
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] tentativa = line.Split(',');
                    string nome = tentativa[0];
                    double preco = double.Parse(tentativa[1],CultureInfo.InvariantCulture);
                    int quantidade = int.Parse(tentativa[2]);
                    list.Add(new Product(nome, preco, quantidade));
                }
                using (StreamWriter sw = File.AppendText(summary))
                {
                    foreach (Product li in list)
                    {
                        sw.WriteLine(li.Nome + "," + li.Valortotal().ToString("f2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}