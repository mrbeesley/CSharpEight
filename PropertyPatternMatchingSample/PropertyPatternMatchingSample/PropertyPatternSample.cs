using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyPatternMatchingSample
{
    public static class PropertyPatternSample
    {
        /// <summary>
        /// Added in example of matching on type as well check if it is an employee
        /// then do the employee checks
        /// Example of using properties to match
        /// will return true for employees in region US and manager in UK
        /// </summary>
        public static bool IsUsBasedWithUkManager(object o)
        {
            return o is Employee e && 
                e is { Region: "US", ReportsTo: { Region: "UK" } };
        }
    }
}
