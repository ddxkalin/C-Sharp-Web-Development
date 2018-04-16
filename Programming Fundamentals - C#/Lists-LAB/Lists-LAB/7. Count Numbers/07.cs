using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Count_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            if (numbers.Count > 0)
            {
                numbers.Sort();
                var previous = numbers[0];
                var count = 1;

                for (int i = 1; i < numbers.Count; i++)
                {
                    var currentNum = numbers[i];
                    if (currentNum == previous)
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{previous} - {count}");
                        count = 1;
                    }

                    previous = currentNum;
                }
            }
            
        }
    }
}
