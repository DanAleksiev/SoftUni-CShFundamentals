using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<int> l1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> l2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int longer = Math.Max(l1.Count, l2.Count);
            int shorter = Math.Min(l1.Count, l2.Count);
            List<int> combination = new List<int>();
            for (int i = 0; i < shorter; i++)
                {
                combination.Add(l1[i]);
                combination.Add(l2[i]);
                }
            if (l1.Count > l2.Count)
                {
                for (int i = shorter; i < longer; i++)
                    {
                    combination.Add(l1[i]);
                    }
                }
            else
                {
                for (int i = shorter; i < longer; i++)
                    {
                    combination.Add(l2[i]);
                    }
                }
            Console.WriteLine(String.Join(" ", combination));

            }
        }
    }
