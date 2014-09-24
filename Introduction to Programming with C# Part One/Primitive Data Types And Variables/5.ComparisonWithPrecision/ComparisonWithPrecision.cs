using System;

namespace _4.ComparisonWithPrecision
{
    class ComparisonWithPrecision
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the 2 numbers you would like to compare: ");
            double firstNumber = double.Parse(Console.ReadLine()); // Entering the numbers from the console.
            double secondumber = double.Parse(Console.ReadLine());
            bool result = false;
            if (Math.Abs(firstNumber - secondumber) <= 0.000001) // Finding out what is the absolute value of the difference.
            {
                result = true;
            }
            Console.WriteLine("The 2 numbers differer by no more than 0.000001. - " + result);
        }
    }
}
