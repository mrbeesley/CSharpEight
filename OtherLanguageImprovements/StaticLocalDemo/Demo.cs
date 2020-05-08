using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLocalDemo
{
    public class Demo
    {
        private static string Field = "initial-value";
        public void Run()
        {
            var state = 42;
            DoSomethingWithState();
            DoSomethingWithField();

            Console.WriteLine($"State: {state}");
            Console.WriteLine($"Field: {Field}");

            static string DoSomethingWithState()
            {
                return "99";
            }

            static string DoSomethingWithField()
            {
                return Field = "modified!";
            }
        }
    }
}
