using System;

namespace _03.CharactersInRange
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            char c1 = char.Parse(Console.ReadLine());
            char c2 = char.Parse(Console.ReadLine());
            Print(c1, c2);
            }

        static void Print(char c1, char c2)
            {
            int bigger = 0;
            int smaller = 0;
            if (c1 > c2)
                {
                bigger = c1;
                smaller = c2;
                }
            else
                {
                bigger = c2;
                smaller = c1;
                }

            for (int i = smaller + 1; i < bigger; i++)
                {
                Console.Write((char)i + " ");
                }
            }
        }
    }
