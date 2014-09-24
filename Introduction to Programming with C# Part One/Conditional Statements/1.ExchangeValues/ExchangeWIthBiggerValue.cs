using System;

namespace Preparation5
{
    class ExchangeWIthBiggerValue
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double max = firstNumber;
            if (secondNumber > max)
            {
                max = secondNumber;
            }
            Console.WriteLine("The bigger number is: ");
            Console.WriteLine(max);
        }
    }
}
