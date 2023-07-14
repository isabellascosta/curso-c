using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\teste\myfolder\file1.txt";
            string targetPath = @"c:\teste\myfolder\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

               

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}