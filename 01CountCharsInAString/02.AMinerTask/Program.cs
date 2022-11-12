using System;
using System.Collections.Generic;

namespace _02.AMinerTask
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string resource;
            while ((resource = Console.ReadLine())!= "stop")
                {
                int amount = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(resource))
                    {
                    resources[resource] = 0;
                    }
                resources[resource]+= amount;
                }
            foreach(var rak in resources)
                {
                Console.WriteLine($"{rak.Key} -> {rak.Value}");
                }
            }
        }
    }
