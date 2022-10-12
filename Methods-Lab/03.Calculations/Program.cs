using System;
using System.Reflection.PortableExecutable;

namespace _03.Calculations
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string sign = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            switch (sign)
                {
                case "add":
                Add(firstNum, secondNum);
                break;
                case "divide":
                divide(firstNum, secondNum);
                break;
                case "subtract":
                subtract(firstNum, secondNum);
                break;
                case "multiply":
                multiply(firstNum, secondNum);
                break;
                }
            }
        public static void Add(int firstNum, int secondNum)
            {
            Console.WriteLine(firstNum + secondNum);
            }
        public static void subtract(int firstNum, int secondNum)
            {
            Console.WriteLine(firstNum - secondNum);
            }
        public static void divide(int firstNum, int secondNum)
            {
            Console.WriteLine(firstNum / secondNum);
            }
        public static void multiply(int firstNum, int secondNum)
            {
            Console.WriteLine(firstNum * secondNum);
            }
        }
    }
