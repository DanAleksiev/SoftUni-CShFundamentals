using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Dictionary
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            List<string> splitInput = input.Split(" | ").ToList();

            Dictionary<string, string> words = new Dictionary<string, string>();
            foreach (string word in splitInput)
                {
                List<string> list = word.Split(": ").ToList();
                string currentWord = list[0];
                string currentDeff = list[1];
                if (words.ContainsKey(currentWord))
                    {
                    string oldDEf = words[currentWord];
                    words[currentWord] = $"{oldDEf}|{currentDeff}";
                    }
                else
                    {
                    words[currentWord] = currentDeff;
                    }
                }
            List<string> wordToBeTested = new List<string>();
            input = Console.ReadLine();
            while (input != "Test" && input != "Hand Over")
                {
                List<string> splitWords = input.Split(" | ").ToList();
                foreach (string word in splitWords)
                    {
                    wordToBeTested.Add(word);
                    }
                input = Console.ReadLine();
                }

            if (input == "Test")
                {
                foreach (string word in wordToBeTested)
                    {
                    if (words.ContainsKey(word))
                        {
                        string wordDeff = words[word];
                        List<string> splitValue = wordDeff.Split("|").ToList();
                        Console.WriteLine($"{word}:");
                        foreach (var deff in splitValue)
                            {
                            Console.WriteLine($"-{deff}");
                            }
                        }
                    }
                }
            if (input == "Hand Over")
                {
                foreach (var word in words)
                    {
                    Console.Write($"{word.Key} ");
                    }
                }
            }
        }
    }
