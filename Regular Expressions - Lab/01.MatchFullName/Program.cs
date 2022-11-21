using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
    {
    internal class Program
        {
        static void Main(string[] args)
            {
           
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            string names = Console.ReadLine();

            MatchCollection matcedNames =Regex.Matches(names, pattern);
            //Regex regex = new Regex(pattern);

            foreach (Match name in matcedNames)
                {
                Console.Write(name.Value + " ");
                }
            Console.WriteLine();
            }
        }
    }
