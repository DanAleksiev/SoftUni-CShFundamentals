using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<int> originalList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            while (input != "end")
                {
                List<string> list = input
                    .Split()
                    .ToList();
                if (list[0] == "Add")
                    {
                    originalList.Add(int.Parse(list[1]));
                    }
                else if (list[0] == "Remove")
                    {
                    originalList.Remove(int.Parse(list[1]));
                    }
                else if (list[0] == "RemoveAt")
                    {
                    originalList.RemoveAt(int.Parse(list[1]));
                    }
                else if (list[0] == "Insert")
                    {
                    originalList.Insert(int.Parse(list[2]), int.Parse(list[1]));
                    }
                input = Console.ReadLine();
                }
            Console.WriteLine(String.Join(" ", originalList));
            }
        }
    }
