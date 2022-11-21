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
            string[] demons = Regex.Split(Console.ReadLine(), @" *,{1} *");
            SortedDictionary<string, string> demonBook = new SortedDictionary<string, string>();

            foreach (string demon in demons)
                {                                               
                int helth = 0;
                string paternHealth = @"[^0-9\+\-\*\/\.]";
                MatchCollection demonName = Regex.Matches(demon, paternHealth);
                foreach (Match match in demonName)
                    {
                    helth += char.Parse(match.ToString());
                    }
                double damage = 0;
                string paternDamage = @"((|-)\d+\.\d+|(|-)\d+)";
                MatchCollection demonDamage = Regex.Matches(demon, paternDamage);
                foreach (Match match in demonDamage)
                    {
                    damage += double.Parse(match.ToString());
                    }
                string bonusPoints = @"[*\/]";
                MatchCollection bonus = Regex.Matches(demon, bonusPoints);
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
                demonBook[demon] = $" - {helth} health, {damage:f2} damage";              
                }
            foreach(var demon in demonBook)
                {
                Console.WriteLine($"{demon.Key}{demon.Value}");
                }
            }
        }
    }
