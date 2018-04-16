using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    public class Program
    {
        public static void Main()
        {
            List<string> array = Console.ReadLine()
                .Trim()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] commandParams = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string command = commandParams[0];

                switch(command)
                {
                    case "reverse":
                        int reverseStart = int.Parse(commandParams[2]);
                        int reverseCount = int.Parse(commandParams[4]);

                        if (isValid(array, start, count))
                        {
                            array.Reverse(reverseStart, reverseCount);
                        }
                }
                    break;
                case "sort":
                int sortStart = 


                inputLine = Console.ReadLine();
             }
        }
        public static void Reverse(List<string> array, int start, int count)
        {
            List<string> resultArray = array.Skip(start).Take(count).Reverse().ToList();

            array.InsertRange(start, resultArray);
        }


        public static bool isValid(string[] array, int start, int count)
        {


        }
    }
}
