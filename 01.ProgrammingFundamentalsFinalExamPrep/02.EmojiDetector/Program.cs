using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            string pattern = @"(::|\*\*)(?<emoji>[A-Z][a-z]{2,})(\1)";
            MatchCollection emojis = Regex.Matches(input, pattern);
            BigInteger coolTrashhold = 1;
            for (int i = 0; i < input.Length; i++)
                {
                char currentChar = (char)input[i];
                if (char.IsDigit(currentChar))
                    {
                    coolTrashhold *= int.Parse(currentChar.ToString());           
                    }
                }
            Console.WriteLine($"Cool threshold: {coolTrashhold}");
            int coolEmojis = emojis.Count;
            Console.WriteLine($"{coolEmojis} emojis found in the text. The cool ones are:");
            foreach (Match match in emojis)
                {
                string emoji = match.Groups["emoji"].Value;
                int coolnes = 0;
                foreach (char currentChar in emoji)
                    {
                    coolnes += (int)currentChar; ;
                    }
                if (coolnes >= coolTrashhold)
                    {
                    Console.WriteLine(match.ToString());
                    }
                }
            }
        }
    }
