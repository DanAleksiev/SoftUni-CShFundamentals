using System;
using System.Linq;
using System.Net;

namespace _02.Articles
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string[] input = Console.ReadLine()
                .Split(", ");

            var  article = new Article(input[0], input[1], input[2]);


            int edits =int.Parse(Console.ReadLine());

            for (int i = 0; i < edits; i++)
                {
                string[]action = Console.ReadLine().Split(": ");
                string subject = action[0];
                string edit = action[1];

                if (subject == "Edit")
                    {
                    article.Edit(edit);
                    }
                else if (subject == "ChangeAuthor")
                    {
                    article.ChangeAuthor(edit);
                    }
                else if (subject == "Rename")
                    {
                    article.Rename(edit);
                    }
                }
            Console.WriteLine(article);
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

        public void Edit(string article)
            {
            this.Content = article;
            }
        public void ChangeAuthor(string article)
            {
            this.Author = article;
            }
        public void Rename(string article)
            {
            this.Title = article;
            }
        public override string ToString()
            {
            return $"{this.Title} - {this.Content}: {this.Author}";
            }

        }
    }
