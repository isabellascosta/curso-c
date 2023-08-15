using System;


public class ProcessFile
{
    public static void Main()
    {
        DateTime dt = new DateTime(2023, 03, 16, 16, 34, 45);

        Console.WriteLine(dt.ElapsedTime());
        string s1 = "bom dia queridos estudantes";
        Console.WriteLine(s1.Cut(10));
         
    }
}