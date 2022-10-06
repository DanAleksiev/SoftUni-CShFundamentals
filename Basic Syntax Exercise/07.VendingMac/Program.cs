using System;

namespace _07.VendingMac
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            double change = 0;
            double sum = 0;
            double price = 0;  
            while (input != "Start")
                {
                change = double.Parse(input);
                switch (change)
                    {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                      sum +=change;
                    break;

                    default:
                    Console.WriteLine($"Cannot accept {change}");
                    break;
                    }
                input = Console.ReadLine();
                }
            
            while (input != "End")
                {
                input = Console.ReadLine();
                if (input == "Nuts")
                    {
                    price = 2;
                    }
                else if (input == "Water")
                    {
                    price = 0.7;
                    }
                else if (input == "Crisps")
                    {
                    price = 1.5;
                    }
                else if (input == "Soda")
                    {
                    price = 0.8;
                    }
                else if (input == "Coke")
                    {
                    price = 1.0;
                    }
                else if (input == "End")
                    {
                    break;
                    }
                else
                    {
                    price = 0;               
                    }
                if (price == 0)
                    {
                    Console.WriteLine("Invalid product");
                    }
                else if (sum < price)
                    {
                    Console.WriteLine("Sorry, not enough money");
                    }
                else if (sum >= price)
                    {
                    sum-=price;
                    input = input.ToLower();
                    Console.WriteLine($"Purchased {input}");                    
                    }
                }
            Console.WriteLine($"Change: {sum:f2}");

            }
        }
    }
