using System;
using System.Collections.Generic;
using System.Linq;

namespace NegativesAndReverse
{
    public class NegNrev
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var results = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    results.Add(numbers[i]);
                }
            }

            if (results.Count > 1)
            {
                numbers.Reverse();
                Console.WriteLine(String.Join(" ", results));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}