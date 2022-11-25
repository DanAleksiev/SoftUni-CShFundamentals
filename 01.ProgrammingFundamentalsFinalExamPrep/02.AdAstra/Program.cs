using System;
using System.Text.RegularExpressions;

namespace _02.AdAstra
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            string pattern = @"([\||#])(?<food>[A-za-z]+[ ]*[A-Za-z]+)\1(?<exparatin>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";
            int calPerDay = 2000;
            MatchCollection allTheFood = Regex.Matches(input, pattern);
            int totalCals = 0;
            foreach (Match match in allTheFood)
                {
                int currentCals = int.Parse(match.Groups["calories"].Value);
                totalCals += currentCals;
                }
            int daysLeft = totalCals / calPerDay;
            Console.WriteLine($"You have food to last you for: {daysLeft} days!");
            foreach (Match match in allTheFood)
                {
                string food = match.Groups["food"].Value;
                string expDate = match.Groups["exparatin"].Value;
                string currentCals = match.Groups["calories"].Value;
                Console.WriteLine($"Item: {food}, Best before: {expDate}, Nutrition: {currentCals}");
                }
            }
        }
    }
