using System;
using System.Net.Http.Headers;

namespace _03._Gaming_Store
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double funds = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double price = 0;
            double spend = 0;
            while (game != "Game Time")
                {
                bool isFound = true;
                switch (game)
                    {
                    
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99;  break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    default:
                    Console.WriteLine("Not Found");
                    isFound = false;
                    break;
                    }

                    if (price > funds)
                        {
                        Console.WriteLine("Too Expensive");
                        }
                    else if (isFound == true)
                        {
                    funds -= price;
                        spend += price;
                        Console.WriteLine($"Bought {game}");
                        }
                    if (funds == 0)
                        {
                        Console.WriteLine("Out of money!");
                        break;
                        }
                    game = Console.ReadLine();
                    
                if (game == "Game Time")
                    {
                    Console.WriteLine($"Total spent: ${spend:f2}. Remaining: ${funds:f2}");
                    }
                }

            }
        }
    }
