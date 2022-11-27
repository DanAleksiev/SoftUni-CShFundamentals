using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.DestinationMapper
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            string pattern = @"([=|\/])(?<place>[A-Z][A-Za-z]{2,})(\1)";

            MatchCollection map = Regex.Matches(input, pattern);
            int sum = 0;
            List<string> list = new List<string>();
            foreach (Match m in map)
                {
                string place = m.Groups["place"].Value;
                list.Add(place.ToString());
                for (int i = 0; i < place.Length; i++)
                    {
                    sum++;
                    }
                }
            Console.WriteLine($"Destinations: {string.Join(", ", list)}");
            Console.WriteLine($"Travel Points: {sum}");
            }
        }
    }
