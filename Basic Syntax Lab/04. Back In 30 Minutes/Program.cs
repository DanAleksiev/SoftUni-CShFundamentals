using System;

namespace _04._Back_In_30_Minutes
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int hour = int.Parse (Console.ReadLine());
            int minute = int.Parse (Console.ReadLine());

            minute = minute + 30;

            if (minute > 60)
                {
                hour++;
                minute = minute - 60;
                }
            if (hour > 23)
                {
                hour = 0;
                }

            Console.WriteLine($"{hour}:{minute:d2}");

            }
        }
    }
