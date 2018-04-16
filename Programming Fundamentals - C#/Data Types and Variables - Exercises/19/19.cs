using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalPictures = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var filterFactor = double.Parse(Console.ReadLine());
            var uploadingTime = double.Parse(Console.ReadLine());

            double percentage = filterFactor / 100.0;
            var usefulPictures = (int)Math.Ceiling(totalPictures * percentage);

            long picturesCount = totalPictures * (long)filterTime;
            long uploadedPictures = usefulPictures * (long)uploadingTime;

            Console.WriteLine(TimeSpan.FromSeconds(picturesCount +uploadedPictures).ToString(new string('d',1) + @"\:hh\:mm\:ss"));
        }
    }
}
