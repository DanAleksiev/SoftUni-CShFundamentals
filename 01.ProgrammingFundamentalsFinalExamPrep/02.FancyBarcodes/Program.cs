using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(@\#+)(?<code>[A-Z][a-zA-Z\d]{4,}[A-Z])(@\#+)$";
            for (int i = 0; i < n; i++)
                {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                
                if (match.Success)
                    {
                    string code = match.Groups["code"].Value;
                    List<char> chars = code.ToCharArray().ToList();
                    int nums = 0;
                    StringBuilder temp= new StringBuilder();
                    foreach (char currentChar in chars)
                        {
                        if (char.IsDigit(currentChar))
                            {
                            temp.Append(currentChar);
                            nums++;
                            }
                        }
                    if (nums == 0) 
                        {
                        temp.Append("00");
                        }
                    Console.WriteLine($"Product group: {temp}");
                    temp.Clear();
                    }
                else
                    {
                    Console.WriteLine("Invalid barcode");
                    }
                }
            }
        }
    }
