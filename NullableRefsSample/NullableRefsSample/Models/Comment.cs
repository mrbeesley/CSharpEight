using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace NullableRefsSample.Models
{
    public class Comment
    {
        public Comment(string body, Author postedBy)
        {
            Body = body;
            PostedBy = postedBy;
        }

        public string Body { get; set; }
        public Author PostedBy { get; set; }
    }
}
