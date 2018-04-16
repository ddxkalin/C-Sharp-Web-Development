using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(canFitIn(n));

        }

        static string canFitIn(BigInteger n)
        {

            if (n <= long.MaxValue)
            {
                Console.WriteLine("{0} can fit in:", n);
                if (n >= sbyte.MinValue && n <= sbyte.MaxValue)
                    Console.WriteLine("* sbyte");
                if (n >= byte.MinValue && n <= byte.MaxValue)
                    Console.WriteLine("* byte");
                if (n >= short.MinValue && n <= short.MaxValue)
                    Console.WriteLine("* short");
                if (n >= ushort.MinValue && n <= ushort.MaxValue)
                    Console.WriteLine("* ushort");
                if (n >= int.MinValue && n <= int.MaxValue)
                    Console.WriteLine("* int");
                if (n >= uint.MinValue && n <= uint.MaxValue)
                    Console.WriteLine("* uint");
                if (n >= long.MinValue && n <= long.MaxValue)
                    Console.WriteLine("* long");
            }
            else

                Console.WriteLine("{0} can't fit in any type", n);
            
            string output = "";
            return output;
        }
    }
}
 
