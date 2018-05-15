using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Holidays_Between_Two_Dates
{
    class HolidaysBetweenTwoDates
    {
        static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy", CultureInfo.InvariantCulture);

            GetHolidayDays(startDate, endDate);
        }

        private static void GetHolidayDays(DateTime firstDate, DateTime secondDate)
        {
            var holidaysCount = 0;
            for (var date = firstDate; date <= secondDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }

            Console.WriteLine(holidaysCount);
        }
    }

}
