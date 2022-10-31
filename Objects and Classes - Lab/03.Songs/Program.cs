﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int loop = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < loop; i++)
                {
                List<string> input = Console.ReadLine()
                    .Split("_")
                    .ToList();
                string typeList = input[0];
                string name = input[1];
                string time = input[2];
                Song song = new Song(typeList, name, time);
                songs.Add(song);
                }
            string list = Console.ReadLine();

            for (int i = 0; i < songs.Count; i++)
                {
                Song currentSong = songs[i];

                if (list == "all")
                    {
                    Console.WriteLine(currentSong.Name);
                    }
                else if (list == currentSong.TypeList)
                    {
                    Console.WriteLine(currentSong.Name);
                    }
                }
            }
        }


    public class Song
        { 
        public Song(string typeList, string name, string time) 
            {
            TypeList = typeList;
            Name = name;
            Time = time;
            }      
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        }
    }
