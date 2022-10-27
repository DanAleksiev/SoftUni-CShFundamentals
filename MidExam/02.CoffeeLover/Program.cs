using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CoffeeLover
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<string> coffeeInStock = Console.ReadLine()
                .Split()
                .ToList();

            int countCommands = int.Parse(Console.ReadLine());
            string command = null;
            List<string> tempList = new List<string>();
            while (countCommands != 0)
                {
                command = Console.ReadLine();
                tempList = command
                    .Split()
                    .ToList();

                string action = tempList[0];

                if (action == "Include")
                    {
                    coffeeInStock.Add(tempList[1]);
                    }
                else if (action == "Remove")
                    {
                    int index = int.Parse(tempList[2]);

                    if (tempList[1] == "first")
                        {
                        if (index >= 0 && index < coffeeInStock.Count)
                            {
                            coffeeInStock.RemoveRange(0, index);
                            }
                        }
                    else if (tempList[1] == "last")
                        {
                        if (coffeeInStock.Count - index >= 0 && index < coffeeInStock.Count)
                            {
                            int count = coffeeInStock.Count;
                            coffeeInStock.RemoveRange(count - index, index);
                            }                           
                        }
                    }
                else if (action == "Prefer")
                    {
                    int index1 = int.Parse(tempList[1]);
                    int index2 = int.Parse(tempList[2]);
                    bool doesItExist1 = false;
                    bool doesItExist2 = false;
                    if (index1 >= 0 && index1 < coffeeInStock.Count)
                        {
                        doesItExist1 = true;
                        }
                    if (index2 >= 0 && index2 < coffeeInStock.Count)
                        {
                        doesItExist2 = true;
                        }
                    if (doesItExist1 && doesItExist2)
                        {
                        string temp = coffeeInStock[index1];
                        coffeeInStock[index1] = coffeeInStock[index2];
                        coffeeInStock[index2] = temp;
                        }
                    }
                else if (action == "Reverse")
                    {
                    coffeeInStock.Reverse();
                    }
                countCommands--;
                }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffeeInStock));
            }
        }
    }
