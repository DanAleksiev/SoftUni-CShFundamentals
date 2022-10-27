using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;

namespace _10.TopNumber
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int endValue = int.Parse(Console.ReadLine());
            TopNumbers(endValue);
            }
        static void TopNumbers(int endValue)
            {
            for (int i = 0; i < endValue; i++)
                {
                int currentNum = i;
                string lenght = currentNum.ToString();
                int[] individualNum = new int[lenght.Length];
                for (int j = 0; j < lenght.Length; j++)
                    {
                    individualNum[j] = currentNum % 10;
                    currentNum /= 10;
                    }
                int oddNums = 0;
                int sum = 0;
                for (int k = 0; k < individualNum.Length; k++)
                    {
                    sum += individualNum[k];
                    if (individualNum[k] % 2 != 0)
                        {
                        oddNums++;
                        }
                    }
                if (sum % 8 == 0 && oddNums != 0)
                    {
                    Console.WriteLine(i);
                    }
                }
            }
        }
    }
