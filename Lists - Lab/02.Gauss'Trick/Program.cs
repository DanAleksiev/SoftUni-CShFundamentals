using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_Trick
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int n = input.Count/2;

            for (int i = 0; i < n; i++)
                {
                input[i]+=input[input.Count-1];
                input.RemoveAt(input.Count-1);
                }
            Console.WriteLine(String.Join(" ", input));
            }
        }
    }
