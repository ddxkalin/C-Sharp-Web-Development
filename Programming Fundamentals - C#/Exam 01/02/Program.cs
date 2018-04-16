using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class Program
    {
        public static void Main()
        {
            var participants = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var songs = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToList();

            var singerAwards = new Dictionary<string, List<string>>();

            var curInput = Console.ReadLine();
            while (!curInput.Equals("dawn"))
            {
                var input = curInput.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (participants.Contains(input[0]) && songs.Contains(input[1].Trim()))
                {
                    if (!singerAwards.ContainsKey(input[0]))
                    {
                        singerAwards.Add(input[0].Trim(), new List<string>());
                    }

                    if (!singerAwards[input[0]].Contains(input[2].Trim()))
                    {
                        singerAwards[input[0]].Add(input[2].Trim());
                    }
                }

                curInput = Console.ReadLine();
            }

            if (singerAwards.Any())
            {
                foreach (var participant in singerAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine("{0}: {1} awards", participant.Key, participant.Value.Count);
                    foreach (var award in participant.Value.OrderBy(x => x))
                    {
                        Console.WriteLine("--{0}", award);
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
