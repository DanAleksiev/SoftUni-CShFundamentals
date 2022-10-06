using System;

namespace Guess_A_Number
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string again = null;
            while (again != "no")
                {
                Console.Write("Guess a number (1-100): ");
                int input = int.Parse(Console.ReadLine());
                Random num = new Random();
                int pcChoice = num.Next(1, 101);

                while (input != pcChoice)
                    {
                    if (input > pcChoice)
                        {
                        Console.WriteLine("Too High");
                        }
                    else
                        {
                        Console.WriteLine("Too Low");
                        }
                    Console.WriteLine();
                    Console.Write("Guess a number (1-100): ");
                    input = int.Parse(Console.ReadLine());
                    }
                Console.WriteLine("You guessed it!");
                Console.WriteLine();
                Console.WriteLine("Let's try again ?");
                Console.WriteLine();
                again =Console.ReadLine();
                }
            Console.WriteLine("Thanks for playing!");
            }
        }
    }
