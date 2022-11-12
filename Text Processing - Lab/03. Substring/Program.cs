using System;

namespace _03._Substring
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string seek = Console.ReadLine();
            string sorce = Console.ReadLine();
            int index = 0;
            while ((index = sorce.IndexOf(seek)) >= 0) //take the starting index of the word you look for  
                {
                sorce = sorce.Remove(index, seek.Length); 
                }
            Console.WriteLine(sorce);
            }
        }
    }
