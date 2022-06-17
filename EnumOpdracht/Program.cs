using System;

namespace EnumOpdracht
{
    public enum Colors
    { red, blue, green, black }
    class Program
    {


        static void Main(string[] args)
        {

            foreach (string name in Enum.GetNames(typeof(Colors)))
            {
                Console.WriteLine(name);
            }


        }

    }
}
