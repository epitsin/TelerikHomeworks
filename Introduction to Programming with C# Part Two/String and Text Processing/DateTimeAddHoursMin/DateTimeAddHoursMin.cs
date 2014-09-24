//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and 
//prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;

namespace DateTimeAddHoursMin
{
    class DateTimeAddHoursMin
    {
        static void Main()
        {
            string input = "12.7.2009 12:3:23";
            DateTime date = DateTime.ParseExact(input, "d.M.yyyy H:m:s", CultureInfo.InvariantCulture);
            DateTime newDate = date.AddHours(6).AddMinutes(30);
            Console.WriteLine("{0:d.M.yyyy H:m:s}", newDate);
        }
    }
}
