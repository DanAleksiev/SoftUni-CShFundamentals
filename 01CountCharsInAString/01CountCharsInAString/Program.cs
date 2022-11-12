using System;
using System.Collections.Generic;

namespace _01CountCharsInAString
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Dictionary<char, int> chars = new Dictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
                {
                char currentChar = input[i];
                if (currentChar != ' ')
                    {
                    if (!chars.ContainsKey(currentChar))
                        {
                        chars[currentChar] = 0;
                        }
                    chars[currentChar]++;
                    }
                }
            foreach (var currentChar in chars)
                {
                Console.WriteLine($"{currentChar.Key} -> {currentChar.Value}");
                }
            }
        }
    }
