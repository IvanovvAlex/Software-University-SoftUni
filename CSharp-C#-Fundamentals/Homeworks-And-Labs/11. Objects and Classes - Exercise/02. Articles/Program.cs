using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());
            Article article = new Article(firstLine[0], firstLine[1], firstLine[2]);
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Edit")
                {
                    article.Content = command[1];
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.Author = command[1];
                }
                else if (command[0] == "Rename")
                {
                    article.Title = command[1];
                }
            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
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
