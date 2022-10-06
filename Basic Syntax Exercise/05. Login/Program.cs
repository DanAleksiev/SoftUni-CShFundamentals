using System;

namespace _05._Login
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >=0 ; i--)
                {
                char currCh =username[i];       //reverce the password
                 password += currCh;          //save the password
                }
            int fails = 0;

            while (fails <= 4)
                {
                string input = Console.ReadLine();


                if (input != password)
                    {
                    fails++;
                    if (fails == 4)
                        {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                        }
                    Console.WriteLine("Incorrect password. Try again.");
                    }
                else if (input == password)
                    {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                    }
                }
            }
        }
    }
