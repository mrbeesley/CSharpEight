using System;
using System.Linq;

namespace IndicesAndRangesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 10).ToArray();
            var copy = numbers[0..^0]; // copy the whole array
            var allButFirst = numbers[1..]; // gets all but the first item
            var lastItemRange = numbers[^1..]; // gets only the last item from array in an array
            var lastItem = numbers[^1]; // gets the item as an int
            var lastThree = numbers[^3..]; // gets the last three items from array

            // using individual variables to create the range.
            Index middle = 4;
            Index threeFromEnd = ^3;
            Range customRange = middle..threeFromEnd;
            var custom = numbers[customRange];

            Console.WriteLine($"numbers: {string.Join(", ", numbers)}");
            Console.WriteLine($"copy: {string.Join(", ", copy)}");
            Console.WriteLine($"allButFirst: {string.Join(", ", allButFirst)}");
            Console.WriteLine($"lastItemRange: {string.Join(", ", lastItemRange)}");
            Console.WriteLine($"lastItem: {lastItem}");
            Console.WriteLine($"lastThree: {string.Join(", ", lastThree)}");
            Console.WriteLine($"customRange: {customRange}");
            Console.WriteLine($"custom: {string.Join(", ", custom)}");
        }
    }
}
