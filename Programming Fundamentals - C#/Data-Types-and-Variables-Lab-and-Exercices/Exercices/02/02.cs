using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double numberThree = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f18}", numberOne);
            Console.WriteLine("{0:f8}", numberTwo);
            Console.WriteLine("{0:f28}", numberThree);
        }
    }
}
