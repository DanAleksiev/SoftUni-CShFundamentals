using System;

namespace _08.FactorialDivision
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            CalculatingFactorials(n1, n2);
            }
        static void CalculatingFactorials(int n1, int n2)
            {
            double f1 = n1;
            double f2 = n2;
            // calculating the factorial of each number 
            for (int i = n1 - 1; i > 0; i--)
                {
                f1 *= i;
                }
            for (int i = n2 - 1; i > 0; i--)
                {
                f2 *= i;
                }
            Console.WriteLine($"{f1 / f2:f2}");
            }
        }
    }
