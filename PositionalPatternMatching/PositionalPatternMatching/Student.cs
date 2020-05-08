using System;
using System.Collections.Generic;
using System.Text;

namespace PositionalPatternMatching
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastNmae { get; set; }
        public Teacher HomeRoomTeacher { get; set; }
        public int GradeLevel { get; set; }

        public Student(string firstName, string lastName,
            Teacher homeRoomTeacher, int gradeLevel)
        {
            FirstName = firstName;
            LastNmae = lastName;
            HomeRoomTeacher = homeRoomTeacher;
            GradeLevel = gradeLevel;
        }

        public void Deconstruct(out string firstName,
            out string lastName,
            out Teacher homeRoomTeacher,
            out int gradeLevel)
        {
            firstName = FirstName;
            lastName = LastNmae;
            homeRoomTeacher = HomeRoomTeacher;
            gradeLevel = GradeLevel;
        }
    }
}
