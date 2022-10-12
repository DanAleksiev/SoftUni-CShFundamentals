using System;

namespace _08.MathPower
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double baseNum = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double resoult = PowerOFNUm(baseNum, power);
            Console.WriteLine(resoult);
            }
        public static double PowerOFNUm(double baseNum, double power)
            {
            double resoult = Math.Pow(baseNum, power);
            return resoult;
            }
        }
    }
