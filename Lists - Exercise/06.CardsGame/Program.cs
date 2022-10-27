using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<int> player1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> player2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (player1.Count != 0 && player2.Count != 0)
                {
                int card1 = player1[0];
                int card2 = player2[0];
                if (card1 > card2)
                    {
                    player1.Add(card1);
                    player1.Add(card2);
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                    }
                else if (card1 < card2)
                    {
                    player2.Add(card2);
                    player2.Add(card1);
                    player2.RemoveAt(0);
                    player1.RemoveAt(0);
                    }
                else if (card1 == card2)
                    {
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                    }
                }
            if (player1.Count > player2.Count)
                {
                int sum = player1.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
                }
            else
                {
                int sum = player2.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
                }
            }
        }
    }
