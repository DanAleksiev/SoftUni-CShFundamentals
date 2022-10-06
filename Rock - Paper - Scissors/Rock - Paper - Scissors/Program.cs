using System;
using System.Threading;

namespace Rock___Paper___Scissors
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int wins = 0;
            int loses = 0;
            string input = null;

            while (input != "end")
                {
                Console.Write("Choose[r]ock, [p]aper, [s]cissors: ");
                input = Console.ReadLine();
                Console.WriteLine();
                Random randomNum = new Random();
                string pcChoice = null;
                int newRandom = randomNum.Next(0, 3);

                if (newRandom == 0)
                    {
                    pcChoice = "r";
                    Console.WriteLine("The computer chose Rock.");
                    }
                else if (newRandom == 1)
                    {
                    pcChoice = "p";
                    Console.WriteLine("The computer chose Paper.");
                    }
                else if (newRandom == 2)
                    {
                    pcChoice = "s";
                    Console.WriteLine("The computer chose Scissors.");
                    }
                if (pcChoice == input)
                    {
                    Console.WriteLine("The game was draw.");
                    }
                else if (input != "r" && input != "p" && input != "s")
                    {
                    Console.WriteLine("Incorect input.");
                    }
                else
                    {
                    if (input == "r" && pcChoice == "p")
                        {
                        Console.WriteLine("You lose.");
                        loses++;
                        }
                    else if (input == "p" && pcChoice == "s")
                        {
                        Console.WriteLine("You lose.");
                        loses++;
                        }
                    else if (input == "s" && pcChoice == "r")
                        {
                        Console.WriteLine("You lose.");
                        loses++;
                        }
                    else if (input == "r" && pcChoice == "s")
                        {
                        Console.WriteLine("You win.");
                        wins++;
                        }
                    else if (input == "p" && pcChoice == "r")
                        {
                        Console.WriteLine("You win.");
                        wins++;
                        }
                    else if (input == "s" && pcChoice == "p")
                        {
                        Console.WriteLine("You win.");
                        wins++;
                        }
                    }
                Console.WriteLine($"You win: [{wins}]| You lose [{loses}]");
                Console.WriteLine();
                }
            }
        }
    }
