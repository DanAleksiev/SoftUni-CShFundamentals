using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input;
            List<People> people = new List<People>();
            while ((input = Console.ReadLine()) != "End")
                {
                string[] inp = input
                    .Split(' ');
                string name = inp[0];
                string id = inp[1];
                int age = int.Parse(inp[2]);
                bool doesItExist = people
                    .Any(p => p.Id == id);
                if (doesItExist)
                    {
                    People person = people.FirstOrDefault(x => x.Id == id);
                    person.Name = name;
                    person.Age = age;
                    }
                else
                    {
                    People person = new People(name, id, age);
                    people.Add(person);
                    }
                }
            foreach(People person in people.OrderBy(x => x.Age))
                {
                Console.WriteLine(person);
                }
            }
        }
    public class People
        {
        public People(string name, string id, int age)
            {
            Name = name;
            Id = id;
            Age = age;
            }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public override string ToString()
            {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
            }
        }
    }

