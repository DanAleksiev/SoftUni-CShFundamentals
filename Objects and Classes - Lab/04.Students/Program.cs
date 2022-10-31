using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = null;
            List<Student> students = new List<Student>(); //create a list of all lists

            while ((input = Console.ReadLine()) != "end")
                {
                List<string> list = input     //split the input 
                    .Split()
                    .ToList();

                string name = list[0];
                string surname = list[1];
                string age = list[2];
                string homeTown = list[3];

                Student student = new Student(name, surname, age, homeTown);  // save it in the class
                students.Add(student);       //add it to the list of lists
                }
            string city = Console.ReadLine();

            for (int i = 0; i < students.Count; i++)
                {
                Student currentStudent = students[i];              //take each individual student
                if (city == currentStudent.HomeTown)               //check if the home town is the same          
                    {
                    Console.WriteLine($"{currentStudent.Name} {currentStudent.Surname} is {currentStudent.Age} years old."); // print 
                    }
                }
            }
        }
    public class Student
        {
        //constructor
        public Student(string name, string surname, string age, string homeTown)   //define which vars are we taking from the main class 
            {
            Name = name;
            Surname = surname;
            Age = age;
            HomeTown = homeTown;
            }
        //propperties 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }
        }
    }
