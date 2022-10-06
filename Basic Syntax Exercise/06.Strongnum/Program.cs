using System;

namespace _06.Strongnum
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());

            int x = n;
            int factorialSum = 0;
            while (x>0)
                {
                int lastN = x % 10;  // get the last num
                x /= 10;             // get rid of the last num 

                int factoriel = 1 ; // factoriel се изписва (n!) и е равно на (n! = n * (n-1)* (n-2) * до като стигне до * 1) омножението на всички цифри между 1 и самото число
                                    // (5! = 5*4*3*2*1 = 120) 
                for (int i = 2; i <= lastN; i++)
                    {
                    factoriel *= i;
                    }
                factorialSum += factoriel;
                }
            if (factorialSum == n)
                {
                Console.WriteLine("yes");
                }
            else
                {
                Console.WriteLine("no");
                }
            }
        }
    }
