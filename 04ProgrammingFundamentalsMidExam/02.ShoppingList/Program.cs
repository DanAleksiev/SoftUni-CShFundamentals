using System;
using System.Linq;

namespace _02.ShoppingList
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int people = int.Parse(Console.ReadLine());
            int[] wagen = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int maxPeople = 4;
            int full = 0;
            for (int i = 0; i < wagen.Length; i++)
                {
                if (people <= 0) { break; }
                for (int k = 0; k < 4; k++)
                    {
                    if (wagen[i] < maxPeople && people > 0)
                        {
                        wagen[i]++;
                        people--;
                        }
                    }
                if (wagen[i] == maxPeople)
                    {
                    full++;
                    }
                }
            if (people > 0)
                {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(String.Join(" ", wagen));
                }
            else if (people == 0 && full == wagen.Length)
                {
                Console.WriteLine(String.Join(" ", wagen));
                }
            else
                {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(String.Join(" ", wagen));
                }
            }
        }
    }
