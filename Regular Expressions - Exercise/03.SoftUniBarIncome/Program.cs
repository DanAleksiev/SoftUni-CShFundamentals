using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string pattern = @"^\%(?<name>[A-z][a-z]+)%[^\|\$\%\.]*?<(?<product>\w+)>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\%\|\$\.]*?(?<price>\d+(.\d+)?)\$[^\%\|\$\.]*?$";
            string input;
            double income = 0;
            Regex regex = new Regex(pattern);
            while ((input = Console.ReadLine()) != "end of shift")
                {
                Match match = regex.Match(input);

                if (match.Success)
                    {
                    string name = match.Groups["name"].Value;
                    string item = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double totalPrice = price * quantity;
                    income += totalPrice;

                    Console.WriteLine($"{name}: {item} - {totalPrice:f2}");
                    }
                }
            Console.WriteLine($"Total income: {income:f2}");
            }
        }
    }
