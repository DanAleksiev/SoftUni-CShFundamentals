using System;
using System.Collections.Generic;
using System.Transactions;

namespace _06.StudentAcademy
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Dictionary<string, double> studentGrades = new Dictionary<string, double>();
            int period = int.Parse(Console.ReadLine());

            for (int i = 0; i < period; i++)
                {
                string name = Console.ReadLine();
                double grades = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(name))
                    {
                    studentGrades[name] = grades;
                    }
                else
                    {
                    double oldgrade = studentGrades[name];
                    studentGrades[name] = (grades + oldgrade) / 2;
                    }
                }
            foreach (var student in studentGrades)
                {
                if (student.Value >= 4.50)
                    {
                    Console.WriteLine($"{student.Key} -> {student.Value:f2}");
                    }                   
                }
            }
        }
    }
