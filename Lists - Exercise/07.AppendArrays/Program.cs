using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();

            List<string> arr = input
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var arrays = new List<int>();
            for (int i = arr.Count - 1; i >= 0; i--)
                {
                arrays.AddRange( arr[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
                }
            Console.Write(string.Join(" ", arrays));
            }
        }
    }