using System;

namespace _01.ReverseStrings
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input;
            while ((input = Console.ReadLine()) != "end")
                {
                string wordInReverse = string.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                    {
                    wordInReverse += input[i];
                    }
                Console.WriteLine($"{input} = {wordInReverse}");
                }
            }
        }
    }
