using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class Program
    {
        public static void Main()
        {
            var text = "asdasdasdasd"
                .ToLower()
                .Replace(" ", string.Empty);

            var result = new SortedDictionary<char, int>();

            foreach (var symbol in text)
            {
                if (!result.ContainsKey(symbol))
                {
                    result[symbol] = 0;
                }

                result[symbol]++;
            }
            foreach (var item in collection)
            {

            }
        }
    }
}
