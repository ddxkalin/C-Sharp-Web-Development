using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_Adjacent_Equal_Numbers
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    numbers[i] += numbers[i - 1];
                    numbers.Remove(numbers[i - 1]);
                    i = 0;
                }
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
