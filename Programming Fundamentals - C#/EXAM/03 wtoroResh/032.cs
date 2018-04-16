using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_wtoroResh
{
    public class Program
    {
        public static void Main()
        {
            var beehives = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(a => a >= 0)
                .ToArray();

            var hornets = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(a => a >= 0)
                .ToArray();

            long hornetsAll = hornets.Sum();
            long hornetsCounter = 0;

            for (int i = 0; i < beehives.Length; i++)
            {
                var battle = beehives[i] - hornetsAll;

                if (battle < 0) 
                {
                    beehives[i] = 0;
                    continue;
                }
                else
                {
                    beehives[i] = beehives[i] - hornets.Sum();

                    hornets[hornetsCounter] = 0;
                    hornetsCounter += 1;
                }
                hornetsAll = hornets.Sum();
            }
            long liveBees = beehives.Sum();
            long liveHornets = hornets.Sum();

            string winners = "";

            if (liveBees == 0) 
            {
                foreach (var hornet in hornets)
                {
                    if (hornet != 0)                    
                        winners += Convert.ToString(hornet) + " ";                    
                }
            }
            else
            {
                foreach (var bees in beehives)
                {
                    if (bees != 0)
                        winners += Convert.ToString(bees) + " ";
                }
            }

            Console.WriteLine(winners.Trim());
        }
    }
}
