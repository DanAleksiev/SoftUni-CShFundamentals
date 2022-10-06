using System;

namespace _05._Special_Numbers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());          

            for (int i = 1; i <= n; i++)             
                {
                int count = i;
                int sum = 0;
                while (count > 0)
                    {
                    sum += count % 10;
                    count /= 10;
                    }
                bool isItTrue = false;
                if (sum == 5 || sum == 7 || sum == 11)
                    {
                    isItTrue = true;
                    }
                Console.WriteLine($"{i} -> {isItTrue}");

                }
            }
        }
    }
