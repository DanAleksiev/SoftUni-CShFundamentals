using System;

namespace _04.TextFilter
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var currentWord in bannedWords)
                {
                text = text.Replace(currentWord, new string('*', currentWord.Length)); //creates a string of the civen char 
                }
            Console.WriteLine(text);
            }
        }
    }
