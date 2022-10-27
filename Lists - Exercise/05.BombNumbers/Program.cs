using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace _05.BombNumbers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<int> minefield = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> bombPower = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int bomb = bombPower[0];
            int power = bombPower[1];

            for (int i = 0; i < minefield.Count; i++)
                {
                if (minefield[i] == bomb)
                    {
                    for (int k = 0; k < power; k++)
                        {
                        if (i + 1 < minefield.Count)
                            {
                            minefield.RemoveAt(i + 1);
                            }
                        }
                    for (int j = 1; j <= power; j++)
                        {
                        if (i - j >= 0)
                            {
                            minefield.RemoveAt(i - j);
                            }
                        }

                    minefield.Remove(bomb);
                    i = -1;
                    }
                }
            Console.WriteLine(minefield.Sum());
            }
        }
    }
