using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int firstDigit = 0; firstDigit < n; firstDigit++)
                for (int secondDigit = 0; secondDigit < n; secondDigit++)
                    for (int thirdDigit = 0; thirdDigit < n; thirdDigit++)
                    {
                        char firstLetter = (char)('a' + firstDigit);
                        char secondLetter = (char)('a' + secondDigit);
                        char thirdLetter = (char)('a' + thirdDigit);
                        Console.WriteLine("{0}{1}{2}",firstLetter,secondLetter,thirdLetter);
                    }
            
        }
    }
}
