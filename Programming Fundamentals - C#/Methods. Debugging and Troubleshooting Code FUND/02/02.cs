using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class Program
    {
        public static void Main()
        {
            printNumbers();
        }
        public static void printNumbers()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            
            if (firstNum>secondNum && firstNum>thirdNum)
                Console.WriteLine(firstNum);
            else if (secondNum>firstNum && secondNum>thirdNum)
                Console.WriteLine(secondNum);
            else if (thirdNum>firstNum && thirdNum>secondNum)
                Console.WriteLine(thirdNum);
        }
    }
}
