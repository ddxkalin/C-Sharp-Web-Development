using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main()
        {

            Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']'}
                .Distinct()
                .Where(w=>w.lenght<5)
                
                }
    }
}
