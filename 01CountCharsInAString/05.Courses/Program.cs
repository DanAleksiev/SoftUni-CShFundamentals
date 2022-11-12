using System;
using System.Collections.Generic;

namespace _05.Courses
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input;

            while ((input = Console.ReadLine()) != "end")
                {
                string[] studentCours = input
                    .Split(" : ");
                string cource = studentCours[0];
                string student = studentCours[1];
                if (!courses.ContainsKey(cource))
                    {
                    courses[cource] = new List<string>();
                    }
                courses[cource].Add(student);
                }

            foreach(var cource in courses)
                {
                Console.WriteLine($"{cource.Key}: {cource.Value.Count}");
                foreach(var value in cource.Value)
                    {
                    Console.WriteLine($"-- {value}");
                    }               
                }
            }
        }
    }
