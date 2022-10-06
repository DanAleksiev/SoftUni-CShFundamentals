using System;
using System.Linq;

namespace _06._Equal_Sum
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();


            bool isItEven = false;
            for (int i = 0; i < input.Length; i++)
                {
                int sumLeft = 0;
                int sumRight = 0;
                for (int j = i + 1; j < input.Length; j++)
                    {
                    sumRight += input[j];
                    }

                for (int j = 0; j < i; j++)
                    {
                    sumLeft += input[j];
                    }

                if (sumLeft == sumRight)
                    {
                    isItEven = true;
                    Console.WriteLine(i);
                    break;
                    }
                }
            if (isItEven == false)
                {
                Console.WriteLine("no");
                }
            }
        }
    }
