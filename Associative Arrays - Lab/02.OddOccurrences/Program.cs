using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string[] input = Console.ReadLine()
                .Split(' ');

            Dictionary<string, int> allOddNum = new Dictionary<string, int>();

            foreach (string word in input)
                {
                string toLower = word.ToLower();                //you cant change var .toLower but you can create a new one !!
                if (!allOddNum.ContainsKey(toLower))
                    {
                    allOddNum.Add(toLower, 0);
                    }
                allOddNum[toLower] += 1;
                }

            foreach (var value in allOddNum)
                {
                if (value.Value % 2 != 0)
                    {
                    Console.Write(value.Key + " ");
                    }
                }
            }
        }
    }
