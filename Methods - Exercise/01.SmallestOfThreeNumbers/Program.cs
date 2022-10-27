using System;

namespace _01.SmallestOfThreeNumbers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int smallest=int.MaxValue;
            for (int i = 0; i < 3; i++)
                {
                int input = int.Parse(Console.ReadLine());
                if (input < smallest)
                    {
                    smallest = input;
                    }
                }
            Print(smallest);
            }
        static void Print(int smallest)
            {
            Console.WriteLine(smallest);
            }
        }
    }
