using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03
{
    public class Program
    {
        public static void Main()
        {
            string key = Console.ReadLine();
            key = Regex.Escape(key);

            var regex = new Regex($@"{key}(.*?){key}(.*?){key}(.*?){key}");

            var score = new Dictionary<string, long>();
            var goals = new Dictionary<string, long>();
            while (true)
            {
                var line = Console.ReadLine();

                if (line == "final")
                {
                    break;
                }

                var match = regex.Match(line);

                var firstTeamReversd = match.Groups[1].Value.Reverse().ToArray();
                var secondTeamReversd = match.Groups[2].Value.Reverse().ToArray();

                var firstTeam = new string (firstTeamReversd).ToUpper();
                var secondTeam = new string (secondTeamReversd).ToUpper();
                var firstTeamGoals = int.Parse(match.Groups[3].Value);
                var secondTeamGoals = int.Parse(match.Groups[4].Value);

                if (!score.ContainsKey(firstTeam))
                {
                    score[firstTeam] = 0;
                }
                if (!score.ContainsKey(secondTeam))
                {
                    score[secondTeam] = 0;
                }
                if (!goals.ContainsKey(firstTeam))
                {
                    goals[firstTeam] = 0;
                }
                if (!goals.ContainsKey(secondTeam))
                {
                    goals[secondTeam] = 0;
                }

                goals[firstTeam] += firstTeamGoals;
                goals[secondTeam] += secondTeamGoals;

                if (firstTeamGoals > secondTeamGoals)
                {

                }
                Console.WriteLine("League standings:");

                int place = 1;
                foreach (var kvp in score.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key))
                {
                    Console.WriteLine($"{place}. {kvp.Key} {kvp.Value}");
                }

                Console.WriteLine("Top 3 scored goals:");
                foreach (var item in collection)
                {

                }
                Console.WriteLine(firstTeam);
                Console.WriteLine(secondTeam);
                Console.WriteLine(firstTeamGoals);
                Console.WriteLine(secondTeamGoals);
            }
        }
    }
}
