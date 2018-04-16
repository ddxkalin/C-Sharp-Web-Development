using System;
using System.Collections.Generic;
using System.Linq;

namespace _06
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            int firstRowLeft =numbers
                .Take(k)
                .Reverse()
                .ToArray();

            var firstRowRight = numbers
                .Reverse()
                .Take(k)
                .ToArray();

            var firstRow = firstRowLeft
                
            var secondRow = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();
            var result = firstRow
                .    
        }
    }
}
