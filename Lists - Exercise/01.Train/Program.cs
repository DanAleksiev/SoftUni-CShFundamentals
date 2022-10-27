using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine(); ;
            while (input != "end")
                {
                List<string> inList = input
                    .Split()
                    .ToList();

                if (inList[0] == "Add")
                    {
                    wagons.Add(int.Parse(inList[1]));
                    }
                else
                    {
                    for (int i = 0; i < wagons.Count; i++)
                        {
                        int ifAdded = wagons[i] + int.Parse(inList[0]);
                        if (ifAdded <= maxCapacity)
                            {
                            wagons[i] += int.Parse(inList[0]);
                            break;
                            }
                        }
                    }
                input = Console.ReadLine();
                }
            Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
