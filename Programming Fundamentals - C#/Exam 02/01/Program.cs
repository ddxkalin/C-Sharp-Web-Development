using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class Program
    {
        public static void Main()
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var runners = int.Parse(Console.ReadLine());
            var averageLaps = int.Parse(Console.ReadLine());
            var lenghtOfTrack = int.Parse(Console.ReadLine());
            var capacityOfTrack = int.Parse(Console.ReadLine());
            double moneyDonated = double.Parse(Console.ReadLine());

            var maxRunners = marathonDays * capacityOfTrack;
            if (runners > maxRunners)
            {
                runners = maxRunners;
            }
           
            long totalMeters = (long)runners * averageLaps * lenghtOfTrack;
            long kilometers = totalMeters / 1000;
            var totalMoneyRaised = kilometers * moneyDonated;
           
            Console.WriteLine("Money raised: {0:F2}", totalMoneyRaised);
        }
    }
}
