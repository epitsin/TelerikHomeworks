using System;

namespace _8.AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Please, enter your current age.");
            int age = int.Parse(Console.ReadLine()); // Reading the age of the person from the console.
            Console.WriteLine("You will be {0} years old after 10 years.", age + 10);
        }
    }
}
