using System;

namespace _01.ValidUsernames
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string username in usernames)
                {
                if (username.Length >= 3 && username.Length <= 16)
                    {
                    bool isValid = false;
                    for (int i = 0; i < username.Length; i++)
                        {
                        char letter = username[i];

                        if (char.IsDigit(letter) || char.IsLetter(letter) || letter == '-' || letter == '_')
                            {
                            isValid = true;
                            }
                        else
                            {
                            isValid = false;
                            break;
                            }
                        }
                    if (isValid)
                        {
                        Console.WriteLine(username);
                        }
                    }
                }
            }
        }
    }
