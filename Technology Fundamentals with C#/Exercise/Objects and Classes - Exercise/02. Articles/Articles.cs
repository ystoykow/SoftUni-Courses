namespace _02._Articles
{
    using System;

    class Articles
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

            public string Edit(string newText)
            {
                Content = newText;
                return Content;
            }

            public string ChangeAuthor(string newText)
            {
                Author = newText;
                return Author;
            }

            public string Rename(string newText)
            {
                Title = newText;
                return Title;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }

        public static void Main()
        {
            string[] text = Console.ReadLine().Split(", ");
            string title = text[0];
            string content = text[1];
            string author = text[2];

            Article article = new Article(title,content,author);

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(":");
                string command = tokens[0];
                string value = tokens[1];

                if (command == "Edit")
                {
                    article.Edit(value.Trim());
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(value.Trim());
                }
                else
                {
                    article.Rename(value.Trim());
                }
            }

            Console.WriteLine(article);
        }
    }
}
