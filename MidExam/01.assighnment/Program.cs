using System;

namespace _01.assighnment
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int day = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            decimal energy = decimal.Parse(Console.ReadLine());
            decimal waterPP = decimal.Parse(Console.ReadLine());
            decimal foodPP = decimal.Parse(Console.ReadLine());

            decimal waterAll = waterPP * players * day;
            decimal foodAll = foodPP * players * day;
            int daysGoing = 1;
            decimal waterBefore = 0;
            decimal foodBefore = 0;
            bool isEnergyPosittive = true;
            while (energy > 0)
                {
                isEnergyPosittive = energy >= 0;
                if (isEnergyPosittive)
                    {
                    waterBefore = waterAll;
                    foodBefore = foodAll;
                    }
                decimal lostEnergy = decimal.Parse(Console.ReadLine());
                energy -= (decimal)lostEnergy;
                

                if (daysGoing % 2 == 0)
                    {
                    energy += energy * 0.05m;
                    waterAll *= 0.7m;

                    }
                if (daysGoing % 3 == 0)
                    {
                    energy += energy * 0.1m;
                    foodAll -= (decimal)foodAll / (decimal)players;
                    }

                if (daysGoing == day)
                    {
                    break;
                    }
                daysGoing++;
                }
            if (energy > 0)
                {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
                }
            else
                {
                Console.WriteLine($"You will run out of energy. You will be left with {foodBefore:f2} food and {waterBefore:f2} water.");
                }
            }
        }
    }
