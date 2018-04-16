using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine(); 
            var age = Console.ReadLine();
            string gender = Console.ReadLine(); 
            var id = long.Parse(Console.ReadLine());
            var number = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\nLast name: {secondName}\nAge: {age}\nGender: {gender}\nPersonal ID: {id}\nUnique Employee number: {number}");
   
        }
    }
}
