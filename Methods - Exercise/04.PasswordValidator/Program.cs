using System;
using System.Net.WebSockets;

namespace _04.PasswordValidator
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string password = Console.ReadLine();
            bool isInRange = RangeOfPassword(password);
            bool isAlphanumeric = IsAlphaNumeric(password);
            bool moreThenTwoDigits = TwoDigits(password);

            if (isInRange && isAlphanumeric && moreThenTwoDigits)
                {
                Console.WriteLine("Password is valid");
                }
            }
        public static bool RangeOfPassword(string password)
            {
            if (password.Length >= 6 && password.Length <= 10)
                {
                return true;
                }
            Console.WriteLine("Password must be between 6 and 10 characters");
            return false;
            }
        public static bool IsAlphaNumeric(string password)
            {
            foreach (char c in password)
                {
                if (!char.IsLetterOrDigit(c))
                    {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                    }
                }
            return true;
            }
        public static bool TwoDigits(string password)
            {
            int digits = 0;
            char[] chars = password.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
                {
                if (char.IsDigit(chars[i]))
                    {
                    digits++;
                    }
                if (digits >= 2)
                    {
                    return true;
                    }
                }
            Console.WriteLine("Password must have at least 2 digits");
            return false;
            }
        }
    }
