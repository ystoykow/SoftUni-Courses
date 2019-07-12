namespace _05._HTML
{
    using System;
    using System.Collections.Generic;

    public class HTML
    {
        public static void Main()
        {
            string title = Console.ReadLine();
            string article = Console.ReadLine();
            List<string> comments = new List<string>();
            while (true)
            {
                string currentComment = Console.ReadLine();
                if (currentComment == "end of comments")
                {
                    break;
                }
                else
                {
                    comments.Add(currentComment);
                }
            }

            Console.WriteLine($"<h1> \n \t {title} \n</h1>");
            Console.WriteLine($"<article> \n \t {article} \n</article>");
            foreach (var item in comments)
            {
                Console.WriteLine($"<div> \n \t {item} \n</div>");
            }
        }
    }
}