using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.Furniture
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string pattern = @">>(?<item>[A-Za-z]+)<<(?<price>\d+|\d+.\d+)!(?<quantity>\d+)";
            string input;
            List<string> furniture = new List<string>();
            double totalSpend = 0;
            while ((input = Console.ReadLine()) != "Purchase")
                {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                    {
                    var item = match.Groups["item"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furniture.Add(item);
                    double totalPriceItem = price * quantity;
                    totalSpend += totalPriceItem;
                    }
                }

            Console.WriteLine("Bought furniture:");

            foreach (string item in furniture)
                {
                Console.WriteLine(item);
                }

            Console.WriteLine($"Total money spend: {totalSpend:f2}");
            }
        }
    }
