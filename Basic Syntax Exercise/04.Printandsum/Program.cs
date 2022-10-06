using System;
using System.Threading;

namespace _04.Printandsum
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int star = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int n = star;
            int sum = n;
            Console.Write($"{n} ");
            while (n < stop)
                {
                n++;
                sum+=n;
                Console.Write($"{n} " );
                }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
            }
        }
    }
