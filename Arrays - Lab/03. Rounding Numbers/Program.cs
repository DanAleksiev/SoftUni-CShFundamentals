using System;
using System.Linq;

namespace _03._Rounding_Numbers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double[] numbers = Console.ReadLine()
                .Split ()                     //разделя inputa в зашисимост от символа в скобите
                .Select(double.Parse)         //ковертира числа {не се използва при стринг}
                .ToArray();                   //и го прибавя в избрания от нас формат

            for (int i = 0; i < numbers.Length; i++)
                {
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i],MidpointRounding.AwayFromZero)}");
                }
            }
        }
    }
