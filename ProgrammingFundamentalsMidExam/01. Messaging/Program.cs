using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<int> inputIndex = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            
            List<int> sums = new List<int>();
            for (int i = 0; i < inputIndex.Count; i++)
                {
                int index = inputIndex[i];
                int sumI = 0;
                while (index != 0)
                    {
                    sumI += index % 10;
                    index /= 10;                  
                    }
                sums.Add(sumI);
                }
            for (int i = 0; i < sums.Count; i++)
                {
                int num = sums[i];
                Console.Write(input[sums[i]]);
                }
            }
        }
    }
