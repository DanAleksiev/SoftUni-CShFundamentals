using System;
using System.Collections.Generic;
using System.Linq;

namespace cheatSheetMethods_
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //.Split(" ", StringSplitOptions.RemoveEmptyEntries) //за премахване на допълнителни разтояния
            //you can exchange .split() with .orderBy(x=>x)

            numbers.Add(1); //add a num at the end
            numbers.Remove(1); //removest the first sinbal between the brackets
            numbers.RemoveAt(1); //removes the num from the chosen index
            numbers.RemoveAll(x => x == 2); //removes all who are equal to the num
            numbers.Insert(0, 2); //insert on (index) the (num) and mooves all after +1 index
            numbers.Sort(); //sort
            numbers.AddRange(new int[] {1,2}); //add multiple nums
            numbers.FirstOrDefault(x=>x == 2); //finds the first resoult 
            Console.WriteLine(numbers.Contains(2));

            Console.WriteLine(String.Join(Environment.NewLine, numbers)); //Environment.NewLine print new lines

            // sum()
            Console.WriteLine(numbers.Sum());

            // min()
            Console.WriteLine(numbers.Min());

            // max()
            Console.WriteLine(numbers.Max());

            // avarage()
            Console.WriteLine(numbers.Average());

            // skip()
            Console.WriteLine(String.Join(" ", numbers.Skip(2)));

            // take()
            Console.WriteLine(String.Join(" ", numbers.Take(2)));

            // orderBy()
            Console.WriteLine(String.Join(" ", numbers.OrderBy(x => x)));

            // orderByDecending()
            Console.WriteLine(String.Join(" ", numbers.OrderByDescending(x => x)));

            // where()
            Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 == 0)));
            Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 != 0)));
            Console.WriteLine(String.Join(" ", numbers.Where(x => x > 5)));

            // all()
            Console.WriteLine(String.Join(" ", numbers.All(x => x % 2 == 0))); //if all returns bool
            Console.WriteLine(String.Join(" ", numbers.All(x => x > 0)));

            // any()
            Console.WriteLine(String.Join(" ", numbers.Any(x => x % 2 == 0))); //at least 1 returns bool
            Console.WriteLine(String.Join(" ", numbers.Any(x => x % 2 != 0)));

            // select()
            Console.WriteLine(String.Join(" ", numbers.Select(x => x + 2)));  //adds to every index
            Console.WriteLine(String.Join(" ", numbers.Select(x => x / 2)));
            Console.WriteLine(String.Join(" ", numbers.Select(x => x * 2)));
            }
        }
    }
