using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            string pattern = @"\b(?<user>[a-z]+[\.\-\\_]*?[a-z]+)@(?<hash>[a-z]+[\.\-\\_]*?[a-z]+\.[a-z]+([\.\-\\_]*?[a-z]+)*)\b";
            MatchCollection match = Regex.Matches(input, pattern);
            foreach (Match m in match)
                {
                Console.WriteLine(m.Value);
                }

            }
        }
    }
