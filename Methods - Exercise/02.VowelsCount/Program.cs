using System;

namespace _02.VowelsCount
    {
    internal class Program
        {

        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            FindVowls(input);

            }
        static void FindVowls(string input)
            {
            int nOfVowls = 0;
            char[] vowls = new char[] { 'o', 'i', 'u', 'e', 'a', 'y' };
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
                {
                for (int j = 0; j < vowls.Length; j++)
                    {
                    if (input[i] == vowls[j])
                        {
                        nOfVowls++;
                        }
                    }
                }
            Console.WriteLine(nOfVowls);
            }

        }
    }
