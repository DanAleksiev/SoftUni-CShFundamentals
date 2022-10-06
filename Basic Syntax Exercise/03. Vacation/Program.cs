using System;
using System.Diagnostics;

namespace _03._Vacation
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int nPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();


            double discount = 0;
            double pricePerTicket = 0;
            double sum = 0;

            if (type == "Students")
                {
                if (day == "Friday")
                    {
                    pricePerTicket = 8.45;
                    }
                else if (day == "Saturday")
                    {
                    pricePerTicket = 9.80;
                    }
                else if (day == "Sunday")
                    {
                    pricePerTicket = 10.46;
                    }
                if (nPeople >= 30)
                    {
                    discount = 0.15;
                    }
                }
            else if (type == "Business")
                {
                if (day == "Friday")
                    {
                    pricePerTicket = 10.90;
                    }
                else if (day == "Saturday")
                    {
                    pricePerTicket = 15.60;
                    }
                else if (day == "Sunday")
                    {
                    pricePerTicket = 16;
                    }
                if (nPeople >= 100)
                    {
                    nPeople -= 10;
                    }
                }
            else if (type == "Regular")
                {
                if (day == "Friday")
                    {
                    pricePerTicket = 15;
                    }
                else if (day == "Saturday")
                    {
                    pricePerTicket = 20;
                    }
                else if (day == "Sunday")
                    {
                    pricePerTicket = 22.50;
                    }
                if (nPeople >= 10 && nPeople <= 20)
                    {
                    discount = 0.05;
                    }
                }
            double total = nPeople*pricePerTicket;
            if (discount != 0)
                {
                total -= total* discount;
                }
            Console.WriteLine($"Total price: {total:f2}");
            
            }
        }
    }
