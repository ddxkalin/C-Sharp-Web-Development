using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();

            numbers.Sort();
            numbers.ForEach(Console.WriteLine);
        }
    }
}
