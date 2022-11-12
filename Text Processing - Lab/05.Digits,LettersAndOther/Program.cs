using System;
using System.Text;

namespace _05.Digits_LettersAndOther
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            StringBuilder characters = new StringBuilder();
            StringBuilder numbers = new StringBuilder();
            StringBuilder everythingElse = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
                {
                char currentChar = input[i];
                if (char.IsLetter(currentChar))
                    {
                    characters.Append(currentChar);
                    }
                else if (char.IsDigit(currentChar))
                    {
                    numbers.Append(currentChar);
                    }
                else
                    {
                    everythingElse.Append(currentChar);
                    }
                }
            Console.WriteLine(numbers);
            Console.WriteLine(characters);
            Console.WriteLine(everythingElse);
            }
        }
    }
