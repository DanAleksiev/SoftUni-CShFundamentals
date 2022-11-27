using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace _01.TheImitationGame
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string masage = Console.ReadLine();
            string action;
            StringBuilder editedMasage = new StringBuilder(masage);
            while ((action = Console.ReadLine()) != "Decode")
                {
                List<string> actionList = action.Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (actionList[0] == "Move")
                    {
                    StringBuilder sb = new StringBuilder();
                    sb.Clear();

                    for (int i = 0; i < int.Parse(actionList[1]); i++)
                        {
                        sb.Append(editedMasage[0]);
                        editedMasage.Remove(0, 1);
                        }
                    editedMasage.Append(sb.ToString());
                    }
                else if (actionList[0] == "Insert")
                    {
                    int index = int.Parse(actionList[1]);
                    string value = actionList[2];
                    editedMasage.Insert(index, value);
                    }
                else if (actionList[0] == "ChangeAll")
                    {
                    string replace = actionList[1];
                    string replaceWith = actionList[2];
                    editedMasage.Replace(replace, replaceWith);
                    }
                }
            Console.WriteLine($"The decrypted message is: {editedMasage.ToString()}");
            }
        }
    }
