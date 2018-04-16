using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02
{
    public class Program
    {
        public static void Main()
        {

            var line = Console.ReadLine();

            var broadcast = new Dictionary<string, string>();
            var messages = new Dictionary<long, List<string>>();

            while (line != "Hornet is Green")
            {
                var data = line.Replace(" <-> ", "panamer")
                .Split(new string[] { "panamer" }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                long isFirstANumber = 0;
                bool isNumber = long.TryParse(data[0], out isFirstANumber);
                //messages to dictionary
                if (isNumber == true)
                {
                    if (isOnlyDigitsAndNumbers(data[1]))
                    {
                        var frequency = data[1];
                        if (!messages.ContainsKey(isFirstANumber))
                        {

                            messages[isFirstANumber] = new List<string>();
                            messages[isFirstANumber].Add(frequency);
                        }
                        else
                        {
                            messages[isFirstANumber].Add(data[1]);
                        }
                    }

                }
                //broadcast to dictonary
                else
                {
                    var frequency = data[0];
                    var message = data[1];
                    if (!broadcast.ContainsKey(convertUpperToLower(message)))
                    {

                        broadcast[convertUpperToLower(message)] = frequency;

                    }
                    else
                    {


                        broadcast[convertUpperToLower(message)] = frequency;

                    }

                }


                line = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcast.Any())
            {
                foreach (var kvp in broadcast)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (messages.Any())
            {
                foreach (var kvp in messages)
                {
                    foreach (var item in kvp.Value)
                    {
                        Console.WriteLine($"{kvp.Key.ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0')} -> {item}");
                    }
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }



        static string convertUpperToLower(string s)
        {

            char[] arr1;
            int l, i;
            l = s.Length;
            char ch;
            arr1 = s.ToCharArray(0, l); // Converts string into char array.

            for (i = 0; i < l; i++)
            {
                ch = arr1[i];
                if (Char.IsLower(ch)) // check whether the character is lowercase
                    arr1[i] = char.ToUpper(ch);
                else
                    arr1[i] = char.ToLower(ch); // Converts uppercase character to lowercase.
            }
            i = 0;
            s = "";
            for (i = 0; i < arr1.Length; i++)
            {
                s += arr1[i];
            }
            return s;
        }
        public static bool isOnlyDigitsAndNumbers(string a)
        {
            bool isNumsAndDI = true;
            char[] b = a.ToCharArray();
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] < 65 && b[i] >= 58)
                {
                    isNumsAndDI = false;
                    break;
                }
                if (b[i] >= 91 && b[i] <= 96)
                {
                    isNumsAndDI = false;
                    break;
                }
                if (b[i] <= 47)
                {
                    isNumsAndDI = false;
                    break;
                }
            }

            return isNumsAndDI;
        }
    }
}
            //var userinput = console.readline();

            //var firstquery = new list<string>();
            //var secondquery = new list<string>();

            //var pattern = "@!@#$%^&*()+_";


            //var curinput = console.readline();
            //while (!curinput.equals("hornet is green"))
            //{

            //}

        