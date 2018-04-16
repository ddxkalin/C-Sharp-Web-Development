using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Sort_Numbers
{
    public class Program
    {
        public static void Main()
        {
            string[] userNumbers = Console.ReadLine()
                .Split(' ');

            List<double> nums = new List<double>();

            foreach (string num in userNumbers)
            {
                nums.Add(double.Parse(num));
            }
            nums.Sort();
            Console.WriteLine(string.Join(" <= ", nums));

        }
    }
}
