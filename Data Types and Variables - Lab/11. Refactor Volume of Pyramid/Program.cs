using System;

namespace _11._Refactor_Volume_of_Pyramid
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double hight = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double width = double.Parse(Console.ReadLine());
            double baseSqare = width * lenght;          
            double valume =(baseSqare*hight)/3;
            Console.Write($"Pyramid Volume: {valume:f2}");
            }
        }
    }
