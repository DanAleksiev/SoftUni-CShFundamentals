using System;
using System.Numerics;

namespace _01._Integer_Operations
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int sum = n1 + n2;
            int sum2 = sum / n3;
            BigInteger sum3 = sum2 * n4; //if the num is too big we can use (BigInteger)
            Console.WriteLine(sum3);
            }
        }
    }
