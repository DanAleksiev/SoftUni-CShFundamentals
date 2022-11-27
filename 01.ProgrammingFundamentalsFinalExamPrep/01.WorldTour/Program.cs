using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.WorldTour
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            StringBuilder stops = new StringBuilder(input);
            while ((input = Console.ReadLine()) != "Travel")
                {
                List<string> list = input.Split(":").ToList();
                string action = list[0];
                if (action == "Add Stop")
                    {
                    int index = int.Parse(list[1]);
                    if (index > stops.Length || index < 0)
                        {
                        continue;
                        }
                    else
                        {
                        string place = list[2];
                        stops.Insert(index, place);
                        }
                    }
                else if (action == "Remove Stop")
                    {
                    int startIndex = int.Parse(list[1]);
                    int endIndex = int.Parse(list[2]);

                    if (startIndex > stops.Length || endIndex > stops.Length || startIndex < 0 || endIndex < 0)
                        {
                        continue;
                        }
                    else
                        {
                        int lengt = endIndex - startIndex;
                        stops.Remove(startIndex, lengt + 1);
                        }
                    }
                else if (action == "Switch")
                    {
                    string old = list[1];
                    string newLocation = list[2];
                    stops.Replace(old, newLocation);
                    }
                Console.WriteLine(stops);
                }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
            }
        }
    }
