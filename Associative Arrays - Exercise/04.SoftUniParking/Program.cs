using System;
using System.Collections.Generic;

namespace _04.SoftUniParking
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Dictionary<string, string> parking = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                {
                string input = Console.ReadLine();
                string [] attempt = input
                    .Split();
                string action = attempt[0];
                string username = attempt[1];
 
                if (action == "register")
                    {
                    string numberplate = attempt[2];
                    if (!parking.ContainsKey(username))
                        {
                        parking[username] = numberplate;
                        Console.WriteLine($"{username} registered {numberplate} successfully");
                        }
                    else
                        {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
                        }
                    }
                if (action == "unregister")
                    {
                    if (parking.ContainsKey(username))
                        {
                        Console.WriteLine($"{username} unregistered successfully");
                        parking.Remove(username);
                        }
                    else
                        {
                        Console.WriteLine($"ERROR: user {username} not found");
                        }
                    }
                }
            foreach (var vehicles in parking)
                {
                Console.WriteLine($"{vehicles.Key} => {vehicles.Value}");
                }
            }
        }
    }
