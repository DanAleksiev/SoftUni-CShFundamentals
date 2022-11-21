using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
    {
    internal class Program
        {
        static void Main(string[] args)
            {

            string pattern = @"\+\b359( |-)2\1\d{3}\1\d{4}\b";
            string names = Console.ReadLine();

            MatchCollection matcedPhoneNumbers = Regex.Matches(names, pattern);
            //Regex regex = new Regex(pattern);

            Console.WriteLine(string.Join(", ",matcedPhoneNumbers));
            }
        }
    }
