using System;

namespace _10._Lower_or_Upper
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            char a = char.Parse(Console.ReadLine());
            bool isItLower = false;
            isItLower = Char.IsLower(a); //check if a char is lower or upper case
            if (isItLower== true)
                {
                Console.WriteLine("lower-case");
                }
            else
                {
                Console.WriteLine("upper-case");
                }
            }
        }
    }
