using System;
using System.Linq;

namespace _07._Equal_Arrays
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();            
            int sum = 0;
            int mistake = 0;
            for (int i = 0; i < input.Length; i++)
                {
                if (input[i] != input2[i])
                    {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    mistake++;
                    break;
                    }
                else
                    {
                    sum += input[i];
                    }
                }
                if (mistake == 0)
                {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
                }
            }
        }
    }
