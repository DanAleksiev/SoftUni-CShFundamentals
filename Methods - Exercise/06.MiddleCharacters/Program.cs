using System;

namespace _06.MiddleCharacters
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            string middle = MidString(input);
            Console.WriteLine(middle);
            }

        static string MidString(string input)
            {
            int mid = input.Length / 2;
            bool isItEven = input.Length % 2 == 0;
            char[] midChars = input.ToCharArray();
            if (isItEven)
                {
                string output = $"{midChars[mid-1]}{midChars[mid]}";
                return output;
                }
            else 
                {
                string output = $"{midChars[mid]}";
                return output;
                }
            }
        }
    }
