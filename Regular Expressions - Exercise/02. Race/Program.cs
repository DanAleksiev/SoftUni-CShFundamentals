using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string[] players = Console.ReadLine().Split(", ");

            UpdatesOfThRun(players);
            }

        private static void UpdatesOfThRun(string[] players)
            {
            string distancePattern = @"\d";
            string namePattern = @"[A-Za-z]";
            Dictionary<string, int> playersArr = new Dictionary<string, int>();
            string input;
            while ((input = Console.ReadLine()) != "end of race")
                {
                StringBuilder name = new StringBuilder();
                MatchCollection matchName = Regex.Matches(input, namePattern);
                MatchCollection distance = Regex.Matches(input, distancePattern);
                IfITExsisAddTheTime(players, playersArr, name, matchName, distance);
                }
            PrintOutTheWinners(playersArr);
            }

        private static void PrintOutTheWinners(Dictionary<string, int> playersArr)
            {
            int count = 0;
            playersArr.OrderByDescending(x => x.Value).Take(3);
            var result = playersArr.OrderByDescending(x => x.Value).Take(3);
            foreach (var currentPlayer in result)
                {

                if (count == 0)
                    {
                    Console.WriteLine($"1st place: {currentPlayer.Key}");
                    }
                else if (count == 1)
                    {
                    Console.WriteLine($"2nd place: {currentPlayer.Key}");
                    }
                else if (count == 2)
                    {
                    Console.WriteLine($"3rd place: {currentPlayer.Key}");
                    }
                if (count == 3)
                    {
                    break;
                    }
                count++;
                }
            }

        private static void IfITExsisAddTheTime(string[] players, Dictionary<string, int> playersArr, StringBuilder name, MatchCollection matchName, MatchCollection distance)
            {
            foreach (var letters in matchName)
                {
                var currentChar = letters;
                name.Append(currentChar);
                }
            string currentName = name.ToString();
            name.Clear();
            if (players.Contains(currentName))
                {
                foreach (var currentDi in distance)
                    {
                    int currentDistance = int.Parse(currentDi.ToString());
                    if (!playersArr.ContainsKey(currentName))
                        {
                        playersArr.Add(currentName, currentDistance);
                        }
                    else
                        {
                        playersArr[currentName] += currentDistance;
                        }
                    }
                }
            }
        }
    }

