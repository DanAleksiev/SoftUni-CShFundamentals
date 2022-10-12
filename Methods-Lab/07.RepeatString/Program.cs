using System;

namespace _07.RepeatString
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            int loops = int.Parse(Console.ReadLine());

            RepeatString(input, loops);
            }
        static void RepeatString(string input, int loops)
            {           
            while(loops > 0)
                {
                loops--;
                Console.Write(input);
                }
            

            }
        }
    }
