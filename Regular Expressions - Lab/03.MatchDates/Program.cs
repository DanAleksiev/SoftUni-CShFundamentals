using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string pattern = @"\b(?<day>\d{2})(\.|\/|-)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string names = Console.ReadLine();
            MatchCollection matcedDates = Regex.Matches(names, pattern);

            foreach (Match date in matcedDates)
                {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
                }
            }
        }
    }
