using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<int> original = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input = null;
            while ((input = Console.ReadLine()) != "End") // you can use ReadLine in the loop
                {
                List<string> command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string funk = command[0];

                if (funk == "Add")
                    {
                    original.Add(int.Parse(command[1]));
                    }

                else if (funk == "Insert")
                    {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    if (isNumberInvalid(original, index))
                        {
                        Console.WriteLine("Invalid index");
                        continue;
                        }
                    original.Insert(index, number);
                    }

                else if (funk == "Remove")
                    {
                    int index = int.Parse(command[1]);
                    if (isNumberInvalid(original,index))
                        {
                        Console.WriteLine("Invalid index");
                        continue;
                        }
                    original.RemoveAt(index);
                    }

                else if (funk == "Shift")
                    {
                    if (command[1] == "left")
                        {
                        int left = int.Parse(command[2]);
                        ShiftLeft(original, left);
                        }

                    else if (command[1] == "right")
                        {
                        int right = int.Parse(command[2]);
                        ShiftRight(original, right);
                        }
                    }
                }
            Console.WriteLine(String.Join(" ", original));
            }

         static void ShiftLeft(List<int> original, int left)
            {
            for (int i = 0; i < left; i++)
                {
                int savednum = original[0];
                original.RemoveAt(0);
                original.Add(savednum);
                }
            }

        static void ShiftRight(List<int> original, int right)
            {
            for (int i = 0; i < right; i++)
                {
                int savednum = original[original.Count - 1];
                original.RemoveAt(original.Count - 1);
                original.Insert(0, savednum);
                }
            }

        static bool isNumberInvalid(List<int> original, int index) // check if it's a valid index 
             => index < 0 || index >= original.Count;
        }
    }
