using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Article article = new Article(line[0], line[1], line[2]);
                articles.Add(article);
            }
            string orderBy = Console.ReadLine();

            if (orderBy == "title")
            {
                foreach (Article article in articles.OrderBy(n => n.Title))
                {
                    Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                }
            }
            else if (orderBy == "content")
            {
                foreach (Article article in articles.OrderBy(n => n.Content))
                {
                    Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                }
            }
            else if (orderBy == "author")
            {
                foreach (Article article in articles.OrderBy(n => n.Author))
                {
                    Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                }
            }
            
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
