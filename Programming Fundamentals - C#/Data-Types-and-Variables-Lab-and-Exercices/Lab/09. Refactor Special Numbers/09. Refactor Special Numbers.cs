using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum = int.Parse(Console.ReadLine());
            int firstDigit = 0;
            int secondDigit = 0;
            bool special = false;
            for (int i = 1; i <= userNum; i++)
            {
                secondDigit = i;
                while (i > 0)
                {
                    firstDigit += i % 10;
                    i = i / 10;
                }
                special = (firstDigit == 5) || (firstDigit == 7) || (firstDigit == 11);
                Console.WriteLine($"{secondDigit} -> {special}");
                firstDigit = 0;
                i = secondDigit;
            }

        }
    }
}
