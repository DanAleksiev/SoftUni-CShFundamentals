using System;

namespace _06._Foreign_Languages
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string country = Console.ReadLine();

            if (country == "USA"|| country == "England")
                {
                Console.WriteLine("English");
                }
            else if (country == "Argentina" || country == "Mexico"  || country == "Spain")
                {
                Console.WriteLine("Spanish");
                }
            else
                {
                Console.WriteLine("unknown");
                }
            }
        }
    }
