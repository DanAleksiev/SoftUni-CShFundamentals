using System;

namespace _12._Even_Number
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = 1;
            while (n % 2 != 0)
                {
                n= int.Parse(Console.ReadLine());
                if (n%2 != 0)
                    {
                    Console.WriteLine("Please write an even number.");
                    }
                else
                    {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    }
                }
            }
        }
    }
