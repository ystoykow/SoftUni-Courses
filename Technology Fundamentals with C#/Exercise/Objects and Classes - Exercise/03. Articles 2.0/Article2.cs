namespace _03._Articles_2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Article2
    {
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

        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < count; i++)
            {
                string[] text = Console.ReadLine().Split(", ");
                string title = text[0];
                string content = text[1];
                string author = text[2];

                Article someArticle = new Article(title,content,author);

                articles.Add(someArticle);
            }

            string command = Console.ReadLine();
            if (command == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if (command == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
}
