using System;
using System.Text;

namespace _05.MultiplyBigNumber
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            var stringbuilder = new StringBuilder();
            int reminder = 0;

            if (multiplier == 0 || input == "0")
                {
                Console.WriteLine(0);
                return;
                }
            for (int i = input.Length - 1; i >= 0; i--)
                {
                int currDigit = int.Parse(input[i].ToString());
                int product = currDigit * multiplier + reminder;
                int result = product % 10;
                reminder = product / 10;
                stringbuilder.Insert(0, result);
                }
            if (reminder > 0)
                {
                stringbuilder.Insert(0, reminder);
                }
            Console.WriteLine(stringbuilder.ToString());
            }
        }
    }
