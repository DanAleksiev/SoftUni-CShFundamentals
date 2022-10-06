using System;

namespace _03._Exact_Sum_of_Real_Numbers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int numCalc = int.Parse(Console.ReadLine());
            decimal sum = 0;
            while (numCalc != 0)
                {
                sum += sum = decimal.Parse(Console.ReadLine());
                numCalc--;
                }
            Console.WriteLine(sum);
            }
        }
    }
