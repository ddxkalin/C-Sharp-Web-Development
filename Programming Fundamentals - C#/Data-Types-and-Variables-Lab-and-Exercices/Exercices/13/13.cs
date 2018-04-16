using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            if (n=="a" || n=="o" || n=="u" || n=="e" || n=="i")
                Console.WriteLine("vowel");
            else if (n == "1" || n=="9" || n=="8" || n=="7" || n == "6" || n == "5" || n == "4" || n == "3" || n == "2" || n == "0")
                Console.WriteLine("digit");
            else
                Console.WriteLine("other");
        }
    }
}
