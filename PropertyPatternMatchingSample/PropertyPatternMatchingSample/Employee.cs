using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyPatternMatchingSample
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public string Region { get; set; }
        public Employee ReportsTo { get; set; }
    }
}
