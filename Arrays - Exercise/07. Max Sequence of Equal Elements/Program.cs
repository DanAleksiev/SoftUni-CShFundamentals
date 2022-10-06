using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int longestNum = 0;
            int longest = 1;
            int newLongest = 0;
            for (int i = 1; i < input.Length; i++)
                {
                if (input[i] != input[i - 1])
                    {
                    if (longest > newLongest)
                        {
                        newLongest = longest;
                        longestNum = input[i - 1];

                        }
                    longest = 1;
                    }
                else if (input[i] == input[i - 1])
                    {
                    longest++;
                    if (i == input.Length - 1 && longest > newLongest)
                        {
                        newLongest = longest;
                        longestNum = input[i - 1];
                        }
                    }
                }
            int[] longestArr = new int[newLongest];
            for (int i = 0; i < longestArr.Length; i++)
                {
                longestArr[i] = longestNum;
                }
            Console.WriteLine(String.Join(" ", longestArr));
            }
        }
    }
