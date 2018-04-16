using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int min = 60 * hours;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} = hours = {4} = minutes",
                centuries,years,days,hours,min);
        }
    }
}
