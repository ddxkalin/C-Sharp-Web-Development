using System;
using System.Collections.Generic;
using System.Linq;

namespace _1
{
    public class Program
    {
        public static void Main()
        {
            var userNum = int.Parse(Console.ReadLine());
            var arr = new int[userNum];

            for (int i = 0; i < userNum; i++)
            {
                arr[userNum] = int.Parse(Console.ReadLine());
            }

            for (int i = userNum-1; i >=0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
