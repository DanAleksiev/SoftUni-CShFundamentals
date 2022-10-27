using System;
using System.Net.Http.Headers;

namespace _09._Palindrome_Integers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            Palindrome(input);
            }
        static void Palindrome(string input)
            {

            while (input != "END")
                {
                int num = int.Parse(input);
                int num1 = num;
                int[] numBackArr = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                    {
                    int currentChar = num % 10;
                    num /= 10;
                    numBackArr[i] = currentChar;
                    }
                int numBack = int.Parse(String.Join("", numBackArr));
                if (num1 == numBack)
                    {
                    Console.WriteLine("true");
                    }
                else
                    {
                    Console.WriteLine("false");
                    }
                input = Console.ReadLine();
                }

            }
        }
    }
