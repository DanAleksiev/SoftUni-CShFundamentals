using System;
using System.Linq;

namespace _05__Top_Integers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] topInt = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries) //за премахване на допълнителни разтояния
                .Select(int.Parse)
                .ToArray();
          
            for(int i = 0; i < topInt.Length; i++)
                {
                int currentNum = topInt[i];
                bool isTopInteger = true;

                for(int j = i+1 ; j < topInt.Length; j++)
                    {
                    int nextNum = topInt[j];
                    if (nextNum >= currentNum)
                        {
                        isTopInteger = false;
                        break;
                        }
                    }
                if (isTopInteger)
                    {
                    Console.Write(currentNum + " ");
                    }
                //for every num in left
                //for (int k = 0; k < i ; k++)
                //    {

                //    }              
                }
            }
        }
    }
