using System;

namespace _05._Messages
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();

            while (input !=null)
                {
                //създава клавиатура като н стар GSM
                input = Console.ReadLine();
                if (input == null)
                    {
                    break;
                    }
                if (input == "0")
                    {
                    Console.Write(" ");                   
                    }
                else
                    {
                    int length = input.Length;
                    int mainNum = int.Parse(input) % 10;
                    int offset = (mainNum - 2) * 3;
                    if (mainNum == 8 || mainNum == 9)
                        {
                        offset += 1;
                        }
                    int letterIndex = (offset + length - 1);
                    int outcome = letterIndex + 97;
                    char output = (char)outcome;
                    Console.Write(output);
                    }
                }
            }
        }
    }
