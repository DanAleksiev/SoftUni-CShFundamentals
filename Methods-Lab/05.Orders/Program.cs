﻿using System;
using System.Reflection.Metadata;
using System.Xml.Schema;

namespace _05.Orders
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string product = Console.ReadLine();
            int amaont = int.Parse(Console.ReadLine());
            double price = 0;
            switch (product)
                {
                case "coffee":
                price = 1.50;
                break;
                case "water":
                price = 1.00;
                break;
                case "coke":
                price = 1.40;
                break;
                case "snacks":
                price = 2.00;
                break;
                }
            double total = amaont * price;

            prices(total);         
            }
        static void prices(double total)
            {
            Console.WriteLine($"{total:f2}");  
            }
        }
    }
