using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Append_Lists
{
    public class Program
    {
        public static void Main()
        {
            List<string> items = Console.ReadLine()
                .Split('|')
                .ToList();

            items.Reverse();

            var result = new List<string>();

            foreach (var item in items)
            {
                List<string> nums = 
                    item.Split(' ')
                    .ToList();

                foreach (var num in nums)
                {
                    if (num != "") result.Add(num);
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
