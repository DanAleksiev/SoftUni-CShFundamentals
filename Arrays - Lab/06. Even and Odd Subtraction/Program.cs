using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] input = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            int sumUnEven = 0;
            int sumEven = 0;
            for (int i = 0; i < input.Length; i++)
                {
                if (input[i] % 2 == 0)
                    {
                    sumEven += input[i];
                    }
                else
                    {
                    sumUnEven+=input[i];
                    }
                }
            Console.WriteLine(sumEven - sumUnEven);
            }
        }
    }
