using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            var age =int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {firstName} {secondName}. You are {age} years old. ");
        }
    }
}
