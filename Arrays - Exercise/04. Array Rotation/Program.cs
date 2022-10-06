using System;

namespace _04._Array_Rotation
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string[] input=Console.ReadLine()
                .Split(' ');
            int positions = int.Parse(Console.ReadLine());
            int numOfRotations = positions%input.Length;
            for(int i = 0; i < numOfRotations; i++)
                {
                string savedNum = input[0];
                for(int j = 1; j < input.Length; j++)
                    {
                    input[j-1] = input[j];
                    }
                input[input.Length-1] = savedNum;
                }
            Console.WriteLine(string.Join(" ", input));
            }
        }
    }
