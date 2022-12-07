using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamFundamentals
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string originalString = Console.ReadLine();
            StringBuilder decript = new StringBuilder(originalString);

            string input;
            while ((input = Console.ReadLine()) != "Finish")
                {
                List<string> splitInput = input.Split(' ').ToList();
                string action = splitInput[0];
                if (action == "Replace")
                    {
                    string target = splitInput[1];
                    string replacement = splitInput[2];
                    decript.Replace(target, replacement);
                    Console.WriteLine(decript);
                    }
                else if (action == "Cut")
                    {
                    int startIndex = int.Parse(splitInput[1]);
                    int endIndex = int.Parse(splitInput[2]);
                    int lenght = endIndex - startIndex;
                    if (startIndex < decript.Length && endIndex < decript.Length && startIndex >= 0 && endIndex >= 0)
                        {
                        decript.Remove(startIndex, lenght + 1);
                        Console.WriteLine(decript);
                        }
                    else
                        {
                        Console.WriteLine("Invalid indices!");
                        }
                    }
                else if (action == "Make")
                    {
                    string upOrLow = splitInput[1];
                    StringBuilder temp = new StringBuilder();
                    if (upOrLow == "Upper")
                        {
                        temp.Append(decript.ToString().ToUpper());
                        decript.Clear();
                        decript.Append(temp);
                        }
                    else if (upOrLow == "Lower")
                        {
                        temp.Append(decript.ToString().ToLower());
                        decript.Clear();
                        decript.Append(temp);
                        }
                    temp.Clear();
                    Console.WriteLine(decript);
                    }
                else if (action == "Check")
                    {
                    string isContain = splitInput[1];
                    if (decript.ToString().Contains(isContain))
                        {
                        Console.WriteLine($"Message contains {isContain}");
                        }
                    else
                        {
                        Console.WriteLine($"Message doesn't contain {isContain}");
                        }
                    }
                else if (action == "Sum")
                    {
                    int startIndex = int.Parse(splitInput[1]);
                    int endIndex = int.Parse(splitInput[2]);
                    int sum = 0;
                    if (startIndex < decript.Length && endIndex < decript.Length && startIndex >= 0 && endIndex >= 0)
                        {
                        for (int i = startIndex; i <= endIndex; i++)
                            {
                            int charValue = decript[i];
                            sum += charValue;
                            }
                        Console.WriteLine(sum);
                        }
                    else
                        {
                        Console.WriteLine("Invalid indices!");
                        }
                    }
                }
            }
        }
    }
