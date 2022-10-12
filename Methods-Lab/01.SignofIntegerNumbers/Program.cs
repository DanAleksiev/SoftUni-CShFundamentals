using System;
using System.Data;

namespace _01.SignofIntegerNumbers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int input = int.Parse(Console.ReadLine());
            numbers(input);
            }

        static void numbers(int input)
            {
            if (input == 0)
                {
                Console.WriteLine($"The number {input} is zero. ");
                }
            else if (input > 0)
                {
                Console.WriteLine($"The number {input} is positive. ");
                }
            else
                {
                Console.WriteLine($"The number {input} is negative. ");
                }
            }
        }
    }
