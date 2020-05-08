using System;
using System.Collections.Generic;
using System.Text;

namespace PositionalPatternMatching
{
    public static class PositionalPatternSample
    {
        /// <summary>
        /// the _ in the pattern means accept any value
        /// this will only return true for students who have a grade == 7
        /// and a math teacher
        /// the type is oprtional since we receive it and the compiler knows
        /// </summary>
        public static bool IsInSeventhGradeMath(Student s)
        {
            //return s is Student(_, _, Teacher(_, _, "Math"), 7);
            return s is (_, _, (_, _, "Math"), 7);
        }
    }
}
