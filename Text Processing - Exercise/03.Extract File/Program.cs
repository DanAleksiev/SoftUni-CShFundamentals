using System;

namespace _03.Extract_File
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string[] input = Console.ReadLine().Split("\\"); // you cant write a simple \ thats why for a single \ you define it as \\
            string[] fileNameFormat = input[input.Length - 1].Split(".");
            Console.WriteLine($"File name: {fileNameFormat[0]}");
            Console.WriteLine($"File extension: {fileNameFormat[1]}");
            }
        }
    }
