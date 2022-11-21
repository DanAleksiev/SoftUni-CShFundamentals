using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();           
            List<string> demons = input.Split(new string[] { ", ", " ", " - " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            SortedDictionary<string, string> demonBook = new SortedDictionary<string, string>();
            foreach (string demon in demons)
                {
                string paternHealth = @"([A-Za-z])";
                string paternDamage = @"([-+]*\d\.\d|\d+)";
                string bonusPoints = @"[*\\]";
                MatchCollection demonName = Regex.Matches(demon, paternHealth);
                MatchCollection demonDamage = Regex.Matches(demon, paternDamage);
                MatchCollection bonus = Regex.Matches(demon, bonusPoints);
                int helth = 0;
                double damage = 0;
                
                foreach (Match match in demonName)
                    {
                    helth += char.Parse(match.ToString());
                    }
                foreach (Match match in demonDamage)
                    {
                    damage += double.Parse(match.ToString());
                    }
                foreach (Match match in bonus)
                    {
                    if (match.ToString() == "*")
                        {
                        damage *= 2;
                        }
                    else if (match.ToString() == "/")
                        {
                        damage /= 2;
                        }
                    }
                demonBook[demon] = $"- {helth} health, {damage:f2} damage";              
                }
            foreach(var demon in demonBook)
                {
                Console.WriteLine($"{demon.Key}{demon.Value}");
                }
            }
        }
    }
