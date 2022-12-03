using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Xml.Linq;

namespace _03.HeroesOfCodeAndLogicVII
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> heroes = new Dictionary<string, string>();
            string input;
            for (int i = 0; i < n; i++)
                {
                input = Console.ReadLine();
                List<string> splitInput = input.Split(" ").ToList();

                string name = splitInput[0];
                string hp = splitInput[1];
                string mp = splitInput[2];
                string stats = $"{hp}|{mp}";

                heroes[name] = stats;
                }

            while ((input = Console.ReadLine()) != "End")
                {
                List<string> splitInput = input.Split(" - ").ToList();
                string action = splitInput[0];
                string name = splitInput[1];

                if (action == "CastSpell")
                    {
                    int mpCost = int.Parse(splitInput[2]);
                    string spell = splitInput[3];

                    int currentHp, currentMp;
                    SplitStats(heroes, name, out currentHp, out currentMp);

                    if (currentMp >= mpCost)
                        {
                        currentMp -= mpCost;
                        Console.WriteLine($"{name} has successfully cast {spell} and now has {currentMp} MP!");
                        heroes[name] = $"{currentHp}|{currentMp}";
                        }
                    else
                        {
                        Console.WriteLine($"{name} does not have enough MP to cast {spell}!");
                        }
                    }
                else if (action == "TakeDamage")
                    {
                    int hpLost = int.Parse(splitInput[2]);
                    string attacker = splitInput[3];

                    int currentHp, currentMp;
                    SplitStats(heroes, name, out currentHp, out currentMp);

                    currentHp -= hpLost;
                    if (currentHp > 0)
                        {
                        Console.WriteLine($"{name} was hit for {hpLost} HP by {attacker} and now has {currentHp} HP left!");
                        heroes[name] = $"{currentHp}|{currentMp}";
                        }
                    else
                        {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                        heroes.Remove(name);
                        }
                    }
                else if (action == "Recharge")
                    {
                    int mpRecharge = int.Parse(splitInput[2]);

                    int currentHp, currentMp;
                    SplitStats(heroes, name, out currentHp, out currentMp);

                    int originalMp = currentMp;
                    int amountRecovered = mpRecharge;
                    currentMp += mpRecharge;
                    if (currentMp > 200)
                        {
                        amountRecovered = 200 - originalMp ;
                        currentMp = 200;
                        }
                    Console.WriteLine($"{name} recharged for {amountRecovered} MP!");
                    heroes[name] = $"{currentHp}|{currentMp}";
                    }
                else if (action == "Heal")
                    {
                    int heal = int.Parse(splitInput[2]);

                    int currentHp, currentMp;
                    SplitStats(heroes, name, out currentHp, out currentMp);

                    int originalHp = currentHp;
                    int amountRecovered = heal;
                    currentHp += heal;
                    if (currentHp > 100)
                        {                        
                        amountRecovered = 100 - originalHp ;
                        currentHp = 100;
                        }
                    Console.WriteLine($"{name} healed for {amountRecovered} HP!");
                    heroes[name] = $"{currentHp}|{currentMp}";
                    }
                }
            foreach (var hero in heroes)
                {
                string stats = hero.Value;
                List<int> list = stats.Split("|").Select(int.Parse).ToList();
                int currentHp = list[0];
                int currentMp = list[1];

                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {currentHp}");
                Console.WriteLine($"  MP: {currentMp}");
                }
            }

        private static void SplitStats(Dictionary<string, string> heroes, string name, out int currentHp, out int currentMp)
            {
            string stats = heroes[name];
            List<int> list = stats.Split("|").Select(int.Parse).ToList();
            currentHp = list[0];
            currentMp = list[1];
            }
        }
    }
