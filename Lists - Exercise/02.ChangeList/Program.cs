using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string funk = Console.ReadLine();

            while(funk != "end")
                {
                List<string> function = funk
                    .Split()
                    .ToList();
                if (function[0] == "Delete")
                    {
                    input.RemoveAll(x => x == int.Parse(function[1]));
                    }
                else if (function[0] == "Insert")
                    {
                    input.Insert(int.Parse(function[2]), int.Parse(function[1]));
                    }
                funk = Console.ReadLine();
                }
            Console.WriteLine(String.Join(" ",input));
            }
        }
    }
