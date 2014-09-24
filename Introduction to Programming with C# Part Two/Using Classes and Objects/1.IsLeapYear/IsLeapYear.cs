using System;

namespace _10.ClassesAndObjects
{
    class IsLeapYear
    {
        static bool LeapYear(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void Main()
        {
            Console.WriteLine("Please, enter a year to check if it is leap year.");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(LeapYear(year));
        }
    }
}
