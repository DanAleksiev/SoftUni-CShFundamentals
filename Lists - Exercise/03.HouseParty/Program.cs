using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int loops = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < loops; i++)
                {
                List<string> answer = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries) //за премахване на допълнителни разтояния
                    .ToList();

                if (answer[2] == "not")
                    {
                    if (guests.Contains(answer[0]))
                        {
                        guests.Remove(answer[0]);
                        }
                    else
                        {
                        Console.WriteLine($"{answer[0]} is not in the list!");
                        }               
                    }
                else if (answer[2] == "going!" )
                    {
                    if (guests.Contains(answer[0]))
                        {
                        Console.WriteLine($"{answer[0]} is already in the list!");
                        }
                    else
                        {
                        guests.Add(answer[0]);
                        }
                    }
                }
            Console.WriteLine(String.Join(Environment.NewLine, guests)); //Environment.NewLine print new lines
            }
        }
    }
