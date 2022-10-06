using System;

namespace _10._Multiplication_Table
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            do // do while цикъл се използва когато искаш да изпълниш дадена команда в цикала и след това да влезне в ословие !!!
                {
                Console.WriteLine($"{n} X {x} = {n * x}");
                x++;
                } while (x <= 10);
            }
        }
    }
