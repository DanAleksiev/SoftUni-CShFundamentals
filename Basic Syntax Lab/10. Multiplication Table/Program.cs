using System;

namespace _10._Multiplication_Table
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            int x = 1;
            while (x <= 10)
                {
                Console.WriteLine($"{n} X {x} = {n*x}");
                x++;
                }
            }
        }
    }
