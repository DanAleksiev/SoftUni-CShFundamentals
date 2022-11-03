using System;
using System.Linq;

namespace _04.Word_Filter
    {
    internal class Program
        {
        static void Main(string[] args)
            {
             Console.ReadLine()
                .Split()
                .Where(word => word.Length % 2 == 0)
                .ToList()
                .ForEach(Console.WriteLine);
            }
        }
    }
