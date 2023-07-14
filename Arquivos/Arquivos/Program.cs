using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"c:\teste\file1.txt";
            string targetpath = @"c:\teste\file2.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcepath);
                //fileInfo.CopyTo(targetpath);
                string[] lines = File.ReadAllLines(sourcepath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
                   
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}