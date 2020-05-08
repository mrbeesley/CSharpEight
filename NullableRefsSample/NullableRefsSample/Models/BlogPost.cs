using System;
using System.Collections.Generic;
using System.Text;

namespace NullableRefsSample.Models
{
    public class BlogPost
    {
        public BlogPost(string title)
        {
            Title = title;
        }

        public string Title { get; set; }
        public List<Comment> Comments { get; } = new List<Comment>();
    }
}
