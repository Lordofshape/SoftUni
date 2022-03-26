using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_Articles
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> list = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Article article = new Article(input[0], input[1], input[2]);
                list.Add(article);
                
            }
            var command  = Console.ReadLine();
            if (command == "title")
            {           
                List<Article> ordered = new List<Article>(list.OrderBy(list => list.Title));
                Print(ordered);
            }
            else if(command == "content")
            {
                List<Article> ordered = new List<Article>(list.OrderBy(list => list.Content));
                Print(ordered);
            }
            else
            {
                List<Article> ordered = new List<Article>(list.OrderBy(list => list.Author));
                Print(ordered);
            }
           
           void Print(List<Article> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
         
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Author = author;
            this.Content = content;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
