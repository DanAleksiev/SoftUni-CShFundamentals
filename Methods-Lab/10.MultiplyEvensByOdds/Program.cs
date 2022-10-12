using System;
using System.Xml.Schema;

namespace _10.MultiplyEvensByOdds
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double input = Math.Abs(double.Parse(Console.ReadLine()));
            double even = GetSumOfEvenDigits(input);
            double odd = GetSumOfOddDigits(input);
            double total = GetMultipleOfEvenAndOdds(odd, even);
            Console.WriteLine(total);
            }
        public static double GetSumOfEvenDigits(double input)
            {
            double even = 0;
            string lenght = input.ToString();
            for (int i = 0; i < lenght.Length; i++)
                {
                int currentNum = int.Parse(lenght[i].ToString());
                if (currentNum % 2 == 0)
                    {
                    even += currentNum;
                    }
                }
            return even;
            }
        public static double GetSumOfOddDigits(double input)
            {
            double odd = 0;
            string lenght = input.ToString();
            for (int i = 0; i < lenght.Length; i++)
                {
                int currentNum = int.Parse(lenght[i].ToString());
                if (currentNum % 2 != 0)
                    {
                    odd += currentNum;
                    }
                }
            return odd;
            }
        public static double GetMultipleOfEvenAndOdds(double odd, double even)
            {
            double total = odd * even;
            return total;
            }

        }
    }
