using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<int> targets = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input = null;

            while ((input = Console.ReadLine()) != "End")
                {
                List<string> actionList = input
                    .Split()
                    .ToList();
                string action = actionList[0];
                int index = int.Parse(actionList[1]);
                int power = int.Parse(actionList[2]);
                bool doesItExist = false;

                if (index >= 0 && index < targets.Count)
                    {
                    doesItExist = true;
                    }

                if (action == "Shoot")
                    {
                    if (doesItExist)
                        {
                        if (index >= 0 && index < targets.Count)
                            {
                            targets[index] -= power;
                            if (targets[index] <= 0)
                                {
                                targets.RemoveAt(index);
                                }
                            }
                        }
                    }
                else if (action == "Add")
                    {
                    if (doesItExist)
                        {
                        targets.Insert(index, power);
                        }
                    else
                        {
                        Console.WriteLine("Invalid placement!");
                        }
                    }
                else if (action == "Strike")
                    {
                    if (index + power < targets.Count && index - power >= 0)
                        {
                        targets.RemoveRange(index - power, power * 2 + 1); // (index) and (how many after the index) 
                        }
                    else
                        {
                        Console.WriteLine("Strike missed!");
                        }
                    }
                }
            Console.WriteLine(String.Join("|", targets));
            }
        }
    }
