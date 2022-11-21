using System;
using System.Text;

namespace _04.CaesarCipher
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            var encripted = new StringBuilder();
            string input = Console.ReadLine();
            foreach (char c in input)
                {
                int charNumber = c + 3;
                encripted.Append((char)charNumber);
                }
            Console.WriteLine(encripted);
            }
        }
    }
