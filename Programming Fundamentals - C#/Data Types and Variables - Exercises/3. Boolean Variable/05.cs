using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            var userWord = Console.ReadLine();
            if (userWord == "True")
            Console.WriteLine("Yes", Convert.ToBoolean(userWord));
            else if (userWord == "False")
            Console.WriteLine("No", Convert.ToBoolean(userWord));
        }
    }
}