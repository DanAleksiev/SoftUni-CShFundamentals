using System;
using System.Collections.Generic;
using System.Text;

namespace _06.ReplaceRepeatingChars
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string leters = Console.ReadLine();
            var notRepeatingLetters = new List<char>();
            for (int i = 0; i < leters.Length; i++)
                {
                char currentLetter = leters[i];
                if (!notRepeatingLetters.Contains(currentLetter) || notRepeatingLetters[notRepeatingLetters.Count - 1] != currentLetter)
                    {
                    notRepeatingLetters.Add(currentLetter);
                    }
                }
            Console.WriteLine(string.Join("", notRepeatingLetters));
            }
        }
    }
