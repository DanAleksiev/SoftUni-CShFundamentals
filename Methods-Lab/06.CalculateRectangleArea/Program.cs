﻿using System;

namespace _06.CalculateRectangleArea
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = Calculate(width, height);
            Console.WriteLine(area);
            }
        static double Calculate(double width, double height)
            {
            double area = width * height;
            return area;
            }
        }
    }