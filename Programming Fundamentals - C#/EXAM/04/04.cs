using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public class Program
    {
        public static void Main()
        {
            var userNum = Console.ReadLine()
                .Split(new[] { ' ', '=', '-', '>', ':' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var lastestActivity = int.Parse(userNum[0]);
            var legionName = char.Parse(userNum[1]);
            var soldierType = char.Parse(userNum[2]);
            var soldierCount = int.Parse(userNum[3]);






        }
    }
}
