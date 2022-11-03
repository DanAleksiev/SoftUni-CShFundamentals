using System;
using System.Collections.Generic;
using System.Reflection;

namespace _01.AdvertisementMessage
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string[] phases = {"Excellent product."
                , "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can't live without this product." };

            string[] events = { "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"};

            string[] authors = { "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva" };

            string[] cities = { "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse" };

            int n = int.Parse (Console.ReadLine());
           
            for (int i = 0; i < n; i++)
                {
                Random random = new Random();
                int phasesRandom = random.Next(0, phases.Length);
                int eventsRandom = random.Next(0, events.Length);
                int authorRandom = random.Next(0, authors.Length);
                int citieRandom = random.Next(0, cities.Length);
                Console.WriteLine($"{phases[phasesRandom]}{events[eventsRandom]}{authors[authorRandom]}{cities[citieRandom]}");
                }
            }
        }
    }


