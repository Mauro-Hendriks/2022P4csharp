using System;
using System.IO;

namespace FileDirOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo files = new DirectoryInfo(@"C:\Users\SKIKK\betterkitsune");
            Console.WriteLine("bronze");
            foreach (var file in files.GetFiles())
            {
                
                Console.WriteLine(file);
            }
            Console.WriteLine("");
            Console.WriteLine("zilver");
            foreach (var file in files.GetFiles("*", SearchOption.AllDirectories))
            {
                
                Console.WriteLine(file);
            }
        }
    }
}
