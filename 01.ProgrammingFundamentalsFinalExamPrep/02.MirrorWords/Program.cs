using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            string pattern = @"([\@|\#])(?<word1>[A-Za-z]{3,})(\1)(\1)(?<word2>[A-Za-z]{3,})(\1)";
            MatchCollection potentialWords = Regex.Matches(input, pattern);
            Dictionary<string, string> words = new Dictionary<string, string>();
            foreach (Match match in potentialWords)
                {
                string word1 = match.Groups["word1"].Value;
                string word2 = match.Groups["word2"].Value;
                StringBuilder word2Backwords = new StringBuilder();
                for (int i = word2.Length-1; i >= 0; i--)
                    {
                    char currentChar = (char)word2[i];
                    word2Backwords.Append(currentChar);
                    }
                if (word1 == word2Backwords.ToString()) 
                    {
                    words[word1] = word2;  
                    }
                word2Backwords.Clear();
                }
            if (potentialWords.Count == 0) 
                {
                Console.WriteLine("No word pairs found!");
                }
            else
                {
                Console.WriteLine($"{potentialWords.Count} word pairs found!");
                }
            if (words.Count == 0)
                {
                Console.WriteLine("No mirror words!");
                }
            else
                {
                Console.WriteLine("The mirror words are:");
                int count = 0;
                foreach(var mirrorWords in words)
                    {
                    count++;
                    Console.Write($"{mirrorWords.Key} <=> {mirrorWords.Value}");
                    if (count != words.Count)
                        {
                        Console.Write(", ");
                        }
                    }
                }
            }
        }
    }
