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
            var arr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                var commandParts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commandParts[0])
                {
                    case "exchange":
                        arr =Exchange(arr, int.Parse(commandParts[1]));
                        break;
                    case "max":
                    case "min":
                        MaxAndMin(arr, commandParts[0], commandParts[1]);
                        break;
                    case "first":
                    case "last":
                        firstAndLast(arr, commandParts[0], int.Parse(commandParts[1]));
                        break;
                }
            }
        }

        private static void firstAndLast(int[] arr, string commandParts)
        {
            
        }
    }
}
