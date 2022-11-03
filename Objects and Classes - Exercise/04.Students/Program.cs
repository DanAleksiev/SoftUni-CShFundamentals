using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();
            for (int i = 0; i < n; i++)
                {
                string input = Console.ReadLine();
                List<string> student = input
                    .Split(" ")
                    .ToList();
                string name = student[0];
                string surname = student[1];
                double grade = double.Parse(student[2]);

                Students currentStudent = new Students(name, surname, grade);
                students.Add(currentStudent);

                }
            foreach (var student in students.OrderByDescending(x => x.Grade))
                {
                Console.WriteLine(student);
                }
            }
        class Students
            {
            public Students(string name, string surname, double grade)
                {
                Name = name;
                Surname = surname;
                Grade = grade;
                }

            public string Name { get; set; }
            public string Surname { get; set; }
            public double Grade { get; set; }

            public override string ToString()
                {
                return $"{this.Name} {this.Surname}: {this.Grade:f2}";
                }
            }
        }
    }
