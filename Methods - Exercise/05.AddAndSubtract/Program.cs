using System;

namespace _05.AddAndSubtract
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int add = Add(n1, n2);
            int subtract = Subtract(add, n3);

            Console.WriteLine(subtract);
            }
        public static int Add(int n1, int n2)
            {
            return n1 + n2;
            }
        public static int Subtract(int add, int n3)
            {
            return add - n3;
            }
        }
    }
