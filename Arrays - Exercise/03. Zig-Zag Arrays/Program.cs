using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int loops = int.Parse(Console.ReadLine());

            int[] firstLine = new int[loops];
            int[] secondLine = new int[loops];
            for (int i = 0; i < loops; i++)
                {
                int[] input = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();
                if (i % 2 == 0)
                    {
                    firstLine[i] = input[0];
                    secondLine[i] = input[1];
                    }
                else
                    {
                    firstLine[i] = input[1];
                    secondLine[i] = input[0];
                    }
                }
            Console.WriteLine(String.Join(" ", firstLine));
            Console.WriteLine(String.Join(" ", secondLine));
            }
        }
    }
