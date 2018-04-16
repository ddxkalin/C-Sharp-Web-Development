using System;
using System.Threading;

namespace _1
{
    public class Program
    {
        public static void Main()
        {
            var min = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());

            var thread = new Thread(() => PrintEventNums(min, max));
            thread.Start();
            thread.Join();

            Console.WriteLine("Thread finished work!");

        }

        public static void PrintEventNums(int min, int max)
        {
            for (int i = min; i < max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
