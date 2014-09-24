using System;

namespace _5.NumberOfWorkdays
{
    class NumberOfWorkdays
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the final date: ");
            string input = Console.ReadLine();
            DateTime date = DateTime.Parse(input);

            DateTime now = DateTime.Now;

            Console.WriteLine("Please, enter how many hollidays are there betweeen today and the final date?");
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int workingHollidays = 0;

            string[] hollidays = new string[numberOfHolidays];
            for (int i = 0; i < numberOfHolidays; i++)
            {
                Console.WriteLine("Please, enter the date of the {0} holiday: ", (i+1));
                hollidays[i] = Console.ReadLine();
                DateTime IsHolliday = DateTime.Parse(hollidays[i]);
                if (IsHolliday.DayOfWeek != DayOfWeek.Saturday && IsHolliday.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingHollidays++;
                }
            }

            int daysLeft = 0;
            while (now.Day != date.Day)
            {
                if (now.DayOfWeek != DayOfWeek.Saturday && now.DayOfWeek != DayOfWeek.Sunday)
                {
                    daysLeft++;
                }
                now = now.AddDays(1);
            }
            Console.WriteLine("There are {0} working days until then (including today).", daysLeft - workingHollidays);
        }
    }
}
