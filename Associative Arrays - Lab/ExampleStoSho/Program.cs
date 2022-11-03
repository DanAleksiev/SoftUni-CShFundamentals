using System;
using System.Collections.Generic;

namespace CSharpFundamentals
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Dictionary<string, int> phoneNumbers
                = new Dictionary<string, int>();

            phoneNumbers.Add("Stoyan", 10);

            if (phoneNumbers.ContainsKey("12"))
                {
                Console.WriteLine(phoneNumbers["12"]);
                }

            phoneNumbers.Remove("Stoyan");

            foreach (var item in phoneNumbers)
                {
                Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
