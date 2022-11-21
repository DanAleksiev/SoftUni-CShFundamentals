using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            int attacked, destroyed;
            List<string> attPlanets, desPlanets;
            Decrept(n, out attacked, out destroyed, out attPlanets, out desPlanets);

            Print(attacked, destroyed, attPlanets, desPlanets);
            }

        private static void Decrept(int n, out int attacked, out int destroyed, out List<string> attPlanets, out List<string> desPlanets)
            {
            string[] encryptedMassages = new string[n];
            List<string> decreptedMassages = new List<string>();
            for (int i = 0; i < n; i++)
                {
                string input = Console.ReadLine();
                encryptedMassages[i] = input;
                int count = 0;
                string lower = input.ToLower();
                foreach (char ch in lower)
                    {

                    if (ch == 's' | ch == 't' | ch == 'a' | ch == 'r')
                        {
                        count++;
                        }
                    }

                StringBuilder temporaryMassage = new StringBuilder();
                foreach (char ch in encryptedMassages[i])
                    {
                    int currentValue = ch - count;
                    char currentChar = (char)currentValue;
                    temporaryMassage.Append(currentChar);
                    }
                decreptedMassages.Add(temporaryMassage.ToString());
                temporaryMassage.Clear();
                }

            string template = @"[^\@\-\!\:\>]*@(?<planetName>[A-Za-z]+)[^\@\-\!\:\>]*:(?<populatin>\d+)[^\@\-\!\:\>]*!(?<attackType>[ADad])![^\@\-\!\:\>]*->(?<soldier>\d+)[^\@\-\!\:\>]*";
            attacked = 0;
            destroyed = 0;
            attPlanets = new List<string>();
            desPlanets = new List<string>();
            foreach (string currentPlanet in decreptedMassages)
                {
                Match match = Regex.Match(currentPlanet, template);
                string attackType = match.Groups["attackType"].Value;
                string name = match.Groups["planetName"].Value;
                if (attackType == "D")
                    {
                    desPlanets.Add($"-> {name}");
                    destroyed++;
                    }
                else if (attackType == "A")
                    {
                    attPlanets.Add($"-> {name}");
                    attacked++;
                    }
                }
            }

        private static void Print(int attacked, int destroyed, List<string> attPlanets, List<string> desPlanets)
            {
            Console.WriteLine($"Attacked planets: {attacked}");
            if (attacked > 0)
                {
                foreach (string planet in attPlanets.OrderBy(x => x))
                    {
                    Console.WriteLine(planet);
                    }
                }
            Console.WriteLine($"Destroyed planets: {destroyed}");
            if (destroyed > 0)
                {
                foreach (string planet in desPlanets.OrderBy(x => x))
                    {
                    Console.WriteLine(planet);
                    }
                }
            }
        }
    }
