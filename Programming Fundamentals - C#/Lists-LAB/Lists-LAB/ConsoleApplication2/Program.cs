using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumber
{
   public class consoleapp
    {
      public static void Main()
        {
            var listOfNums = new List<int>
            {
                1, 2, 3, 4, 5
            };

            for (int i = 0; i < listOfNums.Count; i++)
            {
                Console.WriteLine(listOfNums[i]);
            }

            foreach (var number in listOfNums)
            {

            }
        }
    }
}
