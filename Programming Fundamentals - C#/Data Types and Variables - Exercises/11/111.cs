using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            double time = hours * 3600 + minutes * 60 + seconds;
            double metersPerSecond = (float) distance /time;
            float kilometersPerHour = ((float)distance / 1000) / ((float)time/3600);
            float milesPerHour = ((float)distance / 1609) / ((float)time/3600);


            Console.WriteLine("{0.0#######}", metersPerSecond +0.0000001);
            Console.WriteLine("{0.0#######}", kilometersPerHour);
            Console.WriteLine("{0.0#######}", milesPerHour + 0.0000001);
        }
    }
}
