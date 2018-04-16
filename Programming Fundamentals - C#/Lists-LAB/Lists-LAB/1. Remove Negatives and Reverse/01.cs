
namespace _1.Remove_Negatives_and_Reverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var results = new List<int>();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] > 0)
                {
                    results.Add(numbers[i]);
                }
            }

            if (results.Count > 0)
                Console.WriteLine(String.Join(" ", results));
            else
                Console.WriteLine("empty");
            
        }
    }
}
        