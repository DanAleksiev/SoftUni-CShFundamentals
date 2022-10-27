using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PhoneShop
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<string> storage = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = null;
            while ((input = Console.ReadLine()) != "End")
                {
                List<string> temp = input
                    .Split()
                    .ToList();
                string command = temp[0];

                if (command == "Add")
                    {
                    string phone = temp[2];
                    bool exist = storage.Contains(phone);
                    if (!exist)
                        {
                        storage.Add(phone);
                        }
                    }
                else if (command == "Remove")
                    {
                    string phone = temp[2];
                    bool exist = storage.Contains(phone);
                    if (exist)
                        {
                        storage.Remove(phone);
                        }
                    }
                else if (command == "Bonus")
                    {
                    string phone = temp[3];
                    List<string> separate = phone
                        .Split(":")
                        .ToList();
                    string exsisting = separate[0];
                    string newPhone = separate[1];
                    bool exist = storage.Contains(exsisting);
                    if (exist)
                        {
                        int index = 0;
                        for (int i = 0; i < storage.Count; i++)
                            {
                            if (exsisting == storage[i])
                                {
                                index = i;
                                break;
                                }
                            }
                        storage.Insert(index+1, newPhone);
                        }
                    }
                else if (command == "Last")
                    {
                    string phone = temp[2];
                    bool exist = storage.Contains(phone);
                    if (exist)
                        {
                        storage.Remove(phone);
                        storage.Add(phone);
                        }
                    }
                }
            Console.WriteLine(string.Join(", ", storage));
            }
        }
    }
