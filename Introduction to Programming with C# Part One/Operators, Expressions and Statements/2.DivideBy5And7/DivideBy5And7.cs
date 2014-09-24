using System;

namespace _2.DivideBy5And7
{
    class DivideBy5And7
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number: ");
            int number = int.Parse(Console.ReadLine());
            // First method
            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("Your number can be divided by 5 and 7 at the same time.");
            }
            else
            {
                Console.WriteLine("Your number cann't be divided by 5 and 7 at the same time.");
            }

            // Second method
            Console.WriteLine(number%5==0 && number%7==0); // The outcome is true or false

            // Third method using ? :
            Console.WriteLine(number % 5 == 0 && number % 7 == 0 ? "Can be divided By 5 and 7 at the same time." : "Can't be divided By 5 and 7 at the same time.");
        }
    }
}
