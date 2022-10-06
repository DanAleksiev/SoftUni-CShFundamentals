using System;

namespace _02._Common_Elements
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string[] input = Console.ReadLine()
                .Split(" ");
            string[] input2 = Console.ReadLine()
                .Split(" ");
            string[] incommon = new string[input.Length];
            for (int i = 0; i < input2.Length; i++)
                {
                for (int j = 0; j < input.Length; j++)
                    {
                    if (input2[i] == input[j])
                        {
                        incommon[i] = input[j];
                        Console.Write(incommon[i]+" ");
                        }
                    }
                }
            }
        }
    }
