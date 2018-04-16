using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            double length, width, height = 0;
            length = double.Parse(Console.ReadLine());
            Console.Write("Length: ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double sumOfAll = 0;
            
            sumOfAll = (length * width * height) /3;
            Console.WriteLine("Pyramid Volume: {0:F2}", sumOfAll);

        }
    }
}
