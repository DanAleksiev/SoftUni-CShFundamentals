using System;

namespace _04.PrintingTriangle
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
                {
                Loop(i);
                }
            for (int i = input-1 ; i >= 1; i--)
                {
                Loop(i);
                }
            }
        public static void Loop(int i)
            {
            for (int j = 1; j <= i; j++)
                {
                Console.Write(j + " ");
                }
            Console.WriteLine();
            }
        }
    }
