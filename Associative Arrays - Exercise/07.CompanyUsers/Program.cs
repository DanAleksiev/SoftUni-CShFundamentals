using System;
using System.Collections.Generic;

namespace _07.CompanyUsers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Dictionary<string, List<string>> companies
                = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "End")
                {
                string[] companyInput = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string company = companyInput[0];
                string id = companyInput[1];

                if (!companies.ContainsKey(company))
                    {
                    companies[company] = new List<string>();
                    }
                if (!companies[company].Contains(id))
                    {
                    companies[company].Add(id);
                    }
                }
            foreach (var company in companies)
                {
                Console.WriteLine(company.Key);
                foreach (var id in company.Value)
                    {
                    Console.WriteLine($"-- {id}");
                    }
                }
            }
        }
    }
