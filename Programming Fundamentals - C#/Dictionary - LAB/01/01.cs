using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
               .Split(' ')
            .Select(double.Parse);

            var result =new SortedDictionary<double, int>();

            foreach (var number in numbers)
            
                if (!result.ContainsKey == 0)
                {
                    result[number]++;
                }
            }

            foreach (var item in collection)
            {

            }
        }
    }
}
