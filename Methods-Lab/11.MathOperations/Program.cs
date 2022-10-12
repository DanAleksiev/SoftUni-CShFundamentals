using System;

namespace _11.MathOperations
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n1 = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Salution(n1, op, n2);
            }

        public static void Salution(int n1, char op, int n2)
            {
            double tot = 0;
            switch (op)
                {
                case '+':
                tot = n1 + n2;
                break;
                case '-':
                tot = n1 - n2;
                break;
                case '*':
                tot = n1 * n2;
                break;
                case '/':
                tot = n1 / n2;
                break;
                }
            Console.WriteLine(tot);
            }
        }
    }
