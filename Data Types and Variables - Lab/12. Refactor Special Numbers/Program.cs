using System;

namespace _12._Refactor_Special_Numbers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int input = int.Parse(Console.ReadLine());
            int total = 0;           
            for (int i = 1; i <= input; i++)
                {
                int count = i;
                bool trFaul = false;
                total = 0;
                while (count > 0)
                    {
                    total += count % 10;
                    count /= 10;
                    }
                if (total == 5 || total == 7 || total == 11)
                    {
                    trFaul = true;
                    }
                Console.WriteLine($"{i} -> {trFaul}");
                }
            }
        }
    }
