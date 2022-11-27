using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ActivationKeys
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            StringBuilder activationKey = new StringBuilder(input);
            while ((input = Console.ReadLine()) != "Generate")
                {
                List<string> splitInput = input.Split(">>>").ToList();
                string action = splitInput[0];
                if (action == "Contains")
                    {
                    string substring = splitInput[1];
                    if (!activationKey.ToString().Contains(substring))
                        {
                        Console.WriteLine("Substring not found!");
                        }
                    else
                        {
                        Console.WriteLine($"{activationKey} contains {substring}");
                        }
                    }
                else if (action == "Flip")
                    {
                    int startIndex = int.Parse(splitInput[2]);
                    int endIndex = int.Parse(splitInput[3]);
                    string lowOrUpper = splitInput[1];
                    StringBuilder newValues = new StringBuilder();
                    StringBuilder oldValues = new StringBuilder();
                    if (lowOrUpper == "Lower")
                        {
                        for (int i = startIndex; i < endIndex; i++)
                            {
                            oldValues.Append(activationKey[i]);
                            newValues.Append(char.ToLower(activationKey[i]));
                            }
                        }
                    else if (lowOrUpper == "Upper")
                        {
                        for (int i = startIndex; i < endIndex; i++)
                            {
                            oldValues.Append(activationKey[i]);
                            newValues.Append(char.ToUpper(activationKey[i]));
                            }
                        }
                    activationKey.Replace(oldValues.ToString(), newValues.ToString());
                    Console.WriteLine(activationKey);
                    }
                else if (action == "Slice")
                    {
                    int startIndex = int.Parse(splitInput[1]);
                    int endIndex = int.Parse(splitInput[2]);
                    int lenght = endIndex - startIndex;
                    activationKey.Remove(startIndex, lenght);
                    Console.WriteLine(activationKey);
                    }
                }
            Console.WriteLine($"Your activation key is: {activationKey}");
            }
        }
    }
