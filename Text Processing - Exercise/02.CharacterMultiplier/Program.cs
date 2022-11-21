using System;

namespace _02.CharacterMultiplier
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string[] input = Console.ReadLine().Split();

            string str1 = input[0];
            string str2 = input[1];
            int isSmaller = str1.Length;
            bool secondIsSmaller = false;

            if (isSmaller > str2.Length)
                {
                secondIsSmaller = true;
                isSmaller = str2.Length;
                }
            int total = 0;
            for (int i = 0; i < isSmaller; i++)
                {
                int tempTotal = str1[i] * str2[i];
                total += tempTotal;
                }

            if (str1.Length != str2.Length)
                {
                if (secondIsSmaller)
                    {
                    for (int i = isSmaller; i < str1.Length; i++)
                        {
                        total += str1[i];
                        }
                    }
                else
                    {
                    for (int i = isSmaller; i < str2.Length; i++)
                        {
                        total += str2[i];
                        }
                    }                
                }
            Console.WriteLine(total);
            }
        }
    }
