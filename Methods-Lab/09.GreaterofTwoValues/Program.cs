using System;
using System.Linq;

namespace _09.GreaterofTwoValues
    {
    internal class Program
        {
        private static object arr;

        static void Main(string[] args)
            {
            string varType = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (varType == "int")
                {
                int sum1 = int.Parse(a);
                int sum2 = int.Parse(b);
                print(sum1, sum2, a, b);
                }
            else if (varType == "char")
                {
                int sum1 = char.Parse(a);
                int sum2 = char.Parse(b);
                print(sum1, sum2, a, b);
                }
            else if (varType == "string")
                {
                int sum1 = 0;
                int sum2 = 0;

                int outcome = a.CompareTo(b);
                if (outcome < 0)
                    {
                    sum1 = outcome;
                    }
                else
                    {
                    sum2 = outcome;
                    }
                print(sum1, sum2, a, b);
                }
            }
        static void print(int sum1, int sum2, string a, string b)
            {
            if (sum1 > sum2)
                {
                Console.WriteLine(a);
                }
            else
                {
                Console.WriteLine(b);
                }
            }

        }
    }
