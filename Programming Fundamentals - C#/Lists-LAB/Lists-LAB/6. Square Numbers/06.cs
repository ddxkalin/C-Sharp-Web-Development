using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Square_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToList();
            
            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNum = numbers[i];
                
                var square = Math.Sqrt(currentNum);
                if (square == (int)square)
                {
                    Console.Write($"{currentNum} ");                    
                }
            }

        }
    }
}
