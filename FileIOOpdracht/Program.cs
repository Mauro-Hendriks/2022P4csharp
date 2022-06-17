using System;
using System.IO;
using System.Text;


namespace FileIOOpdracht
{
    class Program
    {
        
      
        static void Main(string[] args)
        {

            string path = @"C:\Users\SKIKK\F1M4\2022P4csharp\FileIOOpdracht\MyTest.txt";
           
                using (StreamWriter thefile = File.CreateText(path))
                {
                    thefile.WriteLine("Hello and welcome to a new world");
                    
                }
            using (StreamReader readfile = File.OpenText(path))
            {
                string newfile = readfile.ReadLine();
                string[] newnewfile = newfile.Split(':', ',');

                foreach (string file in newnewfile)
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}
