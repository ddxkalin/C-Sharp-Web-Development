using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = double.Parse(Console.ReadLine());
            var weight = double.Parse(Console.ReadLine());

            double perimeter = 2 * height + 2 * weight;
            double area = height * weight;
            
            double diagonal = Math.Sqrt(height * height + weight * weight);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
