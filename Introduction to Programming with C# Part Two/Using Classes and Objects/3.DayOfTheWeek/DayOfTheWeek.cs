using System;

namespace _3.DayOfTheWeek
{
    class DayOfTheWeek
    {

        static void Main()
        {
            Console.WriteLine("Please, enter a date: ");
            string input = Console.ReadLine();
            DateTime day = DateTime.Parse(input);
            Console.WriteLine(day.DayOfWeek);
        }
    }
}
