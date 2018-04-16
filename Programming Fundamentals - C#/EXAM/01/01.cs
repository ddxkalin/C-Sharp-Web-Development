using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01
{
    public class Program
    {
        public static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            var distancePer1000Flaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double moving = (wingFlaps / 1000) * distancePer1000Flaps;
            double flapsInSecs = wingFlaps / 100;
            double timeForRest = (wingFlaps / endurance) * 5;
            double timeInSeconds = timeForRest + flapsInSecs;

            Console.WriteLine($"{moving:f2} m.");
            Console.WriteLine($"{timeInSeconds} s.");
        }
    }
}
