using System;
using System.IO;

namespace StringOpdracht
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string file = File.ReadAllText(@"C:\Users\SKIKK\F1M4\2022P4csharp\StringOpdracht\stringsplit.txt");
            string[] newfile = file.Split(':', ',');
            Console.WriteLine(newfile[0].Replace(" ", ""));
            Console.WriteLine(newfile[1].Replace(" ", ""));
            Console.WriteLine(newfile[2].Replace(" ",""));

        }
    }
}
