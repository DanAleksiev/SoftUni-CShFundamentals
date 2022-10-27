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
            bool check = false;
            while (input != "end")
                {
                List<string> list = input
                    .Split()
                    .ToList();
                if (list[0] == "Add")
                    {
                    check = true;
                    originalList.Add(int.Parse(list[1]));
                    }
                else if (list[0] == "Remove")
                    {
                    check = true;
                    originalList.Remove(int.Parse(list[1]));
                    }
                else if (list[0] == "RemoveAt")
                    {
                    check = true;
                    originalList.RemoveAt(int.Parse(list[1]));
                    }
                else if (list[0] == "Insert")
                    {
                    check = true;
                    originalList.Insert(int.Parse(list[2]), int.Parse(list[1]));
                    }
                else if (list[0] == "Contains")
                    {
                    bool contains = originalList.Contains(int.Parse(list[1]));
                    if (contains)
                        {
                        Console.WriteLine("Yes");
                        }
                    else
                        {
                        Console.WriteLine("No such number");
                        }
                    }
                else if (list[0] == "PrintEven")
                    {
                    Console.WriteLine(String.Join(" ", originalList.Where(x => x % 2 == 0)));
                    }
                else if (list[0] == "PrintOdd")
                    {
                    Console.WriteLine(String.Join(" ", originalList.Where(x => x % 2 != 0)));
                    }
                else if (list[0] == "GetSum")
                    {
                    Console.WriteLine(originalList.Sum());
                    }
                else if (list[0] == "Filter")
                    {
                    if (list[1] == "<")
                        {
                        Console.WriteLine(String.Join(" ", originalList.Where(x => x < int.Parse(list[2]))));
                        }
                    else if (list[1] == "<=")
                        {
                        Console.WriteLine(String.Join(" ", originalList.Where(x => x <= int.Parse(list[2]))));

                        }
                    else if (list[1] == ">")
                        {
                        Console.WriteLine(String.Join(" ", originalList.Where(x => x > int.Parse(list[2]))));
                        }
                    else if (list[1] == ">=")
                        {
                        Console.WriteLine(String.Join(" ", originalList.Where(x => x >= int.Parse(list[2]))));
                        }
                    }
                input = Console.ReadLine();
                }
            if (check)
                {
                Console.WriteLine(String.Join(" ", originalList));
                }
            }
        }
    }
