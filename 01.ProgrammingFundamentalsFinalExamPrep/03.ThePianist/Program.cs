using System;
using System.Collections.Generic;

namespace _03.ThePianist
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> pieces = new Dictionary<string, string>();
            string input;
            for (int i = 0; i < n; i++)
                {
                input = Console.ReadLine();
                string[] split = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piece = split[0];
                string composerKey = $"{split[1]}|{split[2]}";
                pieces[piece] = composerKey;
                }

            while ((input = Console.ReadLine()) != "Stop")
                {
                string[] split = input.Split('|',StringSplitOptions.RemoveEmptyEntries);
                string action = split[0];
                string piece = split[1];
                if (action == "Add")
                    {
                    string composerKey = $"{split[2]}|{split[3]}";
                    if (!pieces.ContainsKey(piece))
                        {
                        string composer = split[2];
                        string key = split[3];
                        pieces[piece] = composerKey;
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                    else
                        {
                        Console.WriteLine($"{piece} is already in the collection!");
                        }
                    }
                else if (action == "Remove")
                    {
                    if (pieces.ContainsKey(piece))
                        {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                        }
                    else
                        {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                    }
                else if (action == "ChangeKey")
                    {                    
                    if (pieces.ContainsKey(piece))
                        {
                        string[]oldKey = pieces[piece].Split('|', StringSplitOptions.RemoveEmptyEntries);
                        string newKey = split[2];
                        oldKey[1] = newKey;
                        pieces[piece] = $"{oldKey[0]}|{oldKey[1]}";
                        Console.WriteLine($"Changed the key of {piece} to {split[2]}!");
                        }
                    else
                        {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                    }
                }
            foreach (var currentPiece in pieces)
                {
                string[] keyComposer = currentPiece.Value.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string composer = keyComposer[0];
                string key = keyComposer[1];

                Console.WriteLine($"{currentPiece.Key} -> Composer: {composer}, Key: {key}");
                }
            }
        }
    }
