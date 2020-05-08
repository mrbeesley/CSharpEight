using NullableRefsSample.Models;
using System;

namespace NullableRefsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new BlogPost("New Post!");


            Console.WriteLine("Hello World!");
        }

        static void PrintPostInfo(BlogPost post)
        {
            Console.WriteLine($"{post.Title} ({post.Title.Length})");
            foreach (var comment in post.Comments)
            {
                var commentPreview = comment.Body.Length > 10
                    ? $"{comment.Body.Substring(0, 10)}..."
                    : comment.Body;
                Console.WriteLine($"{comment.PostedBy.Name} ({comment.PostedBy.Email})");
            }
        }
    }

    
}
