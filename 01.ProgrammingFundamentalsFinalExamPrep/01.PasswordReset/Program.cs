using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.PasswordReset
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
            StringBuilder modifiable = new StringBuilder(input);

            while ((input = Console.ReadLine())!= "Done")
                {
                List<string> splitCommands= input.Split(" ").ToList();
                string action = splitCommands[0];

                if (action == "TakeOdd")
                    {
                    StringBuilder tempString = new StringBuilder();

                    for (int i = 0; i < modifiable.Length; i++)
                        {
                        if (i%2!=0)
                            {
                            tempString.Append(modifiable[i]);
                            }                       
                        }
                    modifiable.Clear();
                    modifiable.Append(tempString);
                    tempString.Clear();
                    Console.WriteLine(modifiable);
                    }
                else if (action == "Cut")
                    {
                    int index = int.Parse(splitCommands[1]);
                    int lenght = int.Parse(splitCommands[2]);
                    modifiable.Remove(index, lenght);
                    Console.WriteLine(modifiable);
                    }
                else if (action == "Substitute")
                    {
                    string substring = splitCommands[1];
                    string substitute = splitCommands[2];
                    if (modifiable.ToString().Contains(substring))
                        {
                        modifiable.Replace(substring, substitute);
                        Console.WriteLine(modifiable);
                        }
                    else
                        {
                        Console.WriteLine("Nothing to replace!");
                        }
                    }
                }
            Console.WriteLine($"Your password is: {modifiable}");
            }
        }
    }
