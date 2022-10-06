using System;

namespace _08._Divisible_by_3
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int input = int.Parse(Console.ReadLine());
            int sum = 1;
            int loop = 1;
            int n = 1;
            Console.WriteLine(n);
            while (loop < input)
                {
                
                n += 2;
                sum += n;
                Console.WriteLine(n);
                loop++;
                }
            Console.WriteLine($"Sum: {sum}");
            }
        }
    }
