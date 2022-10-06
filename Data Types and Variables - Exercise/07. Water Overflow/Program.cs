using System;

namespace _07._Water_Overflow
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int delivary = int.Parse(Console.ReadLine());
            int water = 0;
            int capacity = 255;
            for (int i = 0; i < delivary; i++)
                {
                int amount = int.Parse(Console.ReadLine());
                if (amount > capacity) 
                    {
                    Console.WriteLine("Insufficient capacity!");
                    }
                else
                    {
                    capacity -= amount;
                    water += amount;
                    }
                }
            Console.WriteLine(water);
            }
        }
    }
