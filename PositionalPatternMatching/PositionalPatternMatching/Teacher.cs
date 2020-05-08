using System;
using System.Collections.Generic;
using System.Text;

namespace PositionalPatternMatching
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public Teacher(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public void Deconstruct(out string firstName,
            out string lastName,
            out string subject)
        {
            firstName = FirstName;
            lastName = LastName;
            subject = Subject;
        }
    }
}
