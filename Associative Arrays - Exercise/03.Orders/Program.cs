using System;
using System.Collections.Generic;
using System.Transactions;

namespace _03.Orders
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Dictionary<string, string> items = new Dictionary<string, string>();

            string input;
            while ((input = Console.ReadLine()) != "buy")
                {
                string[] product = input
                    .Split();
                string name = product[0];
                double price = double.Parse(product[1]);
                int quantity = int.Parse(product[2]);

                string priceQuantity;
                if (!items.ContainsKey(name))
                    {
                    priceQuantity = $"{price} {quantity}";
                    items[name] = priceQuantity;
                    }
                else
                    {
                    string[] values = items[name].Split();
                    int currentQuantity = int.Parse(values[1]);
                    quantity += currentQuantity;
                    priceQuantity = $"{price} {quantity}";
                    items[name] = priceQuantity;
                    }
                }
            foreach (var product in items)
                {
                string[] value = product.Value.Split();
                double currentPrice = double.Parse(value[0]);
                int currentQuanity = int.Parse(value[1]);
                double totalPrice = currentPrice * currentQuanity;

                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
                }
            }
        }
    }
