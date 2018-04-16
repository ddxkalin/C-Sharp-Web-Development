using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_exercices
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                decimal piecePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsuleCount = int.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(
                    orderDate.Year,
                    orderDate.Month);
                decimal currentPrice = ((daysInMonth * capsuleCount) * piecePerCapsule);
                totalPrice += currentPrice;

                Console.WriteLine("The price for the coffee is: $(0:F2)",currentPrice);
            }

            Console.WriteLine("Total: $(0:F2)",totalPrice);
        }
    }
}
