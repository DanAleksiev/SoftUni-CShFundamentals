using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace _03.Articles2._0
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int amount = int.Parse(Console.ReadLine());
            List<Article> list = new List<Article>();
            for (int i = 0; i < amount; i++)
                {
                string input = Console.ReadLine();
                List<string> currentArticle = input
                    .Split(", ")
                    .ToList();

                string title = currentArticle[0];
                string content = currentArticle[1];
                string author = currentArticle[2];

                Article article = new Article(title, content, author);
                list.Add(article);
                }
            foreach (var article in list)
                {
                Console.WriteLine(article);
                }
            }
        }
    public class Article
        {
        public Article(string title, string content, string author)
            {
            Title = title;
            Content = content;
            Author = author;
            }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }


        public override string ToString()
            {
            return $"{Title} - {Content}: {Author}";
            }

        }
    }
