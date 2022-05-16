using System;
using System.Collections.Generic;

namespace ListOpdracht
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> birds = new List<string>();
            birds.Add("uil");
            birds.Add("kraai");
            birds.Add("hond");
            birds.Add("papegaai");

            List<string> birds2 = new List<string>();
            birds2.Add("meeuw");
            birds2.Add("duif");

            birds.AddRange(birds2);

            birds.Remove("hond");

            foreach (string bird in birds)
            {
                Console.WriteLine(bird);
            }
        }
    }
}
