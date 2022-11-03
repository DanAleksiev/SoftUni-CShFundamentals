using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _03.WordSynonyms
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synomnyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
                {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synomnyms.ContainsKey(word))
                    {
                    synomnyms.Add(word, new List<string>());
                    synomnyms[word].Add(synonym);
                    }
                else
                    {
                    synomnyms[word].Add(synonym);
                    }
                }
            foreach (var word in synomnyms)
                {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
                }
            }
        }
    }
