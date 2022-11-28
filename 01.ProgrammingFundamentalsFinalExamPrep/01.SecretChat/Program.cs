using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.SecretChat
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            StringBuilder concealedMessage = new StringBuilder(input);
            while ((input = Console.ReadLine()) != "Reveal")
                {
                List<string> operations = input.Split(":|:").ToList();
                string action = operations[0];
                if (action == "InsertSpace")
                    {
                    int index = int.Parse(operations[1]);
                    concealedMessage.Insert(index, " ");
                    }
                else if (action == "Reverse")
                    {
                    string substring = operations[1];
                    if (concealedMessage.ToString().Contains(substring))
                        {
                        int index = concealedMessage.ToString().IndexOf(substring);
                        concealedMessage.Remove(index, substring.Length);
                        char[] tempArr = substring.ToCharArray();
                        Array.Reverse(tempArr);
                        new string(tempArr);
                        concealedMessage.Append(tempArr);
                        }
                    else
                        {
                        Console.WriteLine("error");
                        continue;
                        }
                    }
                else if (action == "ChangeAll")
                    {
                    string target = operations[1];
                    string replacement = operations[2];
                    concealedMessage.Replace(target, replacement);
                    }
                Console.WriteLine(concealedMessage);
                }
            Console.WriteLine($"You have a new text message: {concealedMessage}");
            }
        }
    }
