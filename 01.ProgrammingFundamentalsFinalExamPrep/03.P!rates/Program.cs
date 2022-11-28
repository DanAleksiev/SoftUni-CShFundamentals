using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.P_rates
    {
    internal class Program
        {
        // passing with 92% https://judge.softuni.org/Contests/Practice/Index/2302#2
        static void Main(string[] args)
            {
            string input;
            Dictionary<string, string> cityes = new Dictionary<string, string>();
            input = CityesToPlunder(cityes);
            input = Saling(cityes);
            CitiesThatMadeIt(cityes);
            }

        private static string CityesToPlunder(Dictionary<string, string> cityes)
            {
            string input;
            while ((input = Console.ReadLine()) != "Sail")
                {
                List<string> split = input.Split("||").ToList();
                string city = split[0];
                string population = split[1];
                string gold = split[2];
                if (!cityes.ContainsKey(city))
                    {
                    string peopleGold = $"{population}||{gold}";
                    cityes[city] = peopleGold;
                    }
                else
                    {
                    string value = cityes[city];
                    List<int> peopleGold = value.Split("||").Select(int.Parse).ToList();
                    int newPopulation = int.Parse(population) + peopleGold[0];
                    int newGold = int.Parse(gold) + peopleGold[1];
                    string newValue = $"{newPopulation}||{newGold}";
                    cityes[city] = newValue;
                    }
                }

            return input;
            }

        private static string Saling(Dictionary<string, string> cityes)
            {
            string input;
            while ((input = Console.ReadLine()) != "End")
                {
                List<string> split = input.Split("=>").ToList();
                string action = split[0];
                string city = split[1];
                if (action == "Plunder")
                    {
                    int peopleKilled = int.Parse(split[2]);
                    int gold = int.Parse(split[3]);
                    string townWelth = cityes[city];
                    List<string> townWelthSplit = townWelth.Split("||").ToList();
                    int townPopulation = int.Parse(townWelthSplit[0]) - peopleKilled;
                    int townGold = int.Parse(townWelthSplit[1]) - gold;
                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {peopleKilled} citizens killed.");
                    if (townGold > 0 && townPopulation > 0)
                        {
                        cityes[city] = $"{townPopulation}||{townGold}";
                        }
                    else
                        {
                        cityes.Remove(city);
                        Console.WriteLine($"{city} has been wiped off the map!");
                        }
                    }
                else if (action == "Prosper")
                    {
                    int gold = int.Parse(split[2]);
                    if (gold <= 0)
                        {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        }
                    else
                        {
                        string townWelth = cityes[city];
                        List<string> townWelthSplit = townWelth.Split("||").ToList();
                        int townGold = int.Parse(townWelthSplit[1]) + gold;
                        int townPopulation = int.Parse(townWelthSplit[0]);
                        cityes[city] = $"{townPopulation}||{townGold}";
                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {townGold} gold.");
                        }
                    }
                }

            return input;
            }

        private static void CitiesThatMadeIt(Dictionary<string, string> cityes)
            {
            if (cityes.Count > 0)
                {
                Console.WriteLine($"Ahoy, Captain! There are {cityes.Count} wealthy settlements to go to:");
                foreach (var city in cityes)
                    {
                    List<string> townWelthSplit = city.Value.Split("||").ToList();
                    int people = int.Parse(townWelthSplit[0]);
                    int gold = int.Parse(townWelthSplit[1]);
                    Console.WriteLine($"{city.Key} -> Population: {people} citizens, Gold: {gold} kg");
                    }
                }
            }
        }
    }
