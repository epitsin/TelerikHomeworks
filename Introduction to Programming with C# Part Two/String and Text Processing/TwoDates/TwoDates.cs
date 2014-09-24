//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2004
//Distance: 4 days

using System;

namespace TwoDates
{
    class TwoDates
    {
        static void Main()
        {
            DateTime first = DateTime.Parse(Console.ReadLine());
            DateTime second = DateTime.Parse(Console.ReadLine());
            int daysPassed = second.Day - first.Day;
            if (daysPassed > DateTime.DaysInMonth(first.Year, first.Month))
            {
                daysPassed = DateTime.DaysInMonth(first.Year, first.Month) - first.Day + second.Day;
            }
            Console.WriteLine(daysPassed);
        }
    }
}
