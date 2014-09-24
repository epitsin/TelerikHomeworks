using System;

namespace _4.DescendingOrder
{
    class DescendingOrder
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the 3 numbers: ");
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (secondNumber > firstNumber)
            {
                double a = firstNumber;
                firstNumber = secondNumber;
                secondNumber = a;
            }
            if (thirdNumber > secondNumber)
            {
                double b = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = b;
            }
            if (secondNumber > firstNumber)
            {
                double c = firstNumber;
                firstNumber = secondNumber;
                secondNumber = c;
            }

            Console.WriteLine("The sequence is: {0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
        }
    }
}
