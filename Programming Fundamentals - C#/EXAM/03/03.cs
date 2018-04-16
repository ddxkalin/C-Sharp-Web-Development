using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    public class Program
    {
        public static void Main()
        {
            var beehives = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            
            var hornets = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            
            var hornetsPower = hornets.Sum();
            var beesLeft = new List<int>();

            while (hornetsPower != 0)
            {
                foreach (var bees in beehives)
                {
                    hornets.RemoveAt(0);
                    
                    if (bees >= hornetsPower)
                    {
                        beesLeft.Add(bees - hornetsPower);
                        hornetsPower = hornets.Sum();
                    }
                    // First example works.
                }
            }
            while (hornetsPower<0)
            {
                foreach (var bee in beehives)
                {
                    if (hornetsPower > bee)
                    {
                        beesLeft.Remove(hornetsPower - bee);
                        
                    }
                }
            }
            Console.WriteLine(string.Join(" ", beesLeft));
            
        }
    }
}