using System;
using System.Linq;

namespace _02.CarRace
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int finishLine = input.Length / 2;
            double leftCar = 0;
            double rightCar = 0;

            for (int i = 0; i < finishLine; i++)
                {
                if (input[i] != 0)
                    {
                    leftCar += input[i];
                    }
                else
                    {
                    leftCar *= 0.8;
                    }
                }
            for (int i = input.Length-1; i > finishLine; i--)
                {
                if (input[i] != 0)
                    {
                    rightCar += input[i];
                    }
                else
                    {
                    rightCar *= 0.8;
                    }             
                }
            if (leftCar > rightCar)
                {
                Console.WriteLine($"The winner is right with total time: {(rightCar)}");
                }
            else
                {
                Console.WriteLine($"The winner is left with total time: {(leftCar)}");
                }
            }
        }
    }
