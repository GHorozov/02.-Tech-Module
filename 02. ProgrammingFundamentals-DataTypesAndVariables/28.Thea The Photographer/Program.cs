using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            int secondToFilter = int.Parse(Console.ReadLine());
            int percentOfGoodPictures = int.Parse(Console.ReadLine());
            int timeToUpload = int.Parse(Console.ReadLine());

            int usefulPuctures = (int)(Math.Ceiling(amount * (percentOfGoodPictures / 100d)));
            long timeToFilter = amount * (long)secondToFilter;           
            long upload = (long)usefulPuctures * timeToUpload;
            long totalTime = timeToFilter + upload;

            long days = totalTime / 86400;
            long hours = totalTime % 86400 / 3600;
            long minutes = totalTime % 86400 % 3600 / 60;
            long seconds = totalTime % 86400 % 3600 % 60;


            Console.WriteLine("{0}:{1}:{2}:{3}",days, hours.ToString().PadLeft(2, '0'), minutes.ToString().PadLeft(2, '0'), seconds.ToString().PadLeft(2, '0'));
        }
    }
}
