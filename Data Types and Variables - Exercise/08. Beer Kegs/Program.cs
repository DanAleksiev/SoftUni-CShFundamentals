using System;

namespace _08._Beer_Kegs
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int amount =int.Parse(Console.ReadLine());
            double bigges = double.MinValue;
            string output =null;
            for(int i = 0; i < amount; i++)
                {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int heght = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(2,radius)*heght;
                if (volume > bigges)
                    {
                    bigges = volume;
                    output = model;
                    }
                }
            Console.WriteLine(output);
            }
        }
    }
