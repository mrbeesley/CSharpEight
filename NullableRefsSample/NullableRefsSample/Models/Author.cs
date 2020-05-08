using System;
using System.Collections.Generic;
using System.Text;

namespace NullableRefsSample.Models
{
    public class Author
    {
        public Author(string name, string email)
        {
            Name = name;
            Email = email;
        }


        public string Name { get; set; }
        public string Email { get; set; }
    }
}
