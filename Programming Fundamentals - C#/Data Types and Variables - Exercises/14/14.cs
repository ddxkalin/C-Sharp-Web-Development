using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum = int.Parse(Console.ReadLine());
            
            var secondResult = Convert.ToString(userNum, 2);
            var result = Convert.ToString(userNum, 16).ToUpper();
            Console.WriteLine(result);
            Console.WriteLine(secondResult);
        }
    }
}
