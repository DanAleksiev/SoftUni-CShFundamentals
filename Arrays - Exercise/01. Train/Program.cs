using System;

namespace _01._Train
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int loops = int.Parse(Console.ReadLine());
            int[] pasangers = new int[loops];
            int totalPasangers = 0;
            for (int i = 0; i < loops; i++)
                {
                pasangers[i] = int.Parse(Console.ReadLine());
                totalPasangers += pasangers[i];
                }
            Console.Write(String.Join(" ", pasangers)); // Environment.NewLine е разточние форматирано в всички операционни системи
            Console.WriteLine();
            Console.WriteLine($"{totalPasangers}");
            }
        }
    }
