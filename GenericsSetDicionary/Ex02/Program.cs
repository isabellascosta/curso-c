using System;
using System.Linq;
using System.Threading.Channels;
using System.Numerics;
using System.Linq;


namespace GenericsSetDicionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string path = @"c:\teste\note1.csv";
            int totalvotos = 0;
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votos = int.Parse(line[1]);
                        if (dic.ContainsKey(name))
                        {
                            dic[name] += votos;
                        }
                        else
                        {
                            dic[name] = votos;
                        }

                    }

                    foreach (var item in dic)
                    {

                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
