using System;

namespace _3.BiggestNumber
{
    class BiggerstNumber
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the 3 numbers: ");
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            double max = firstNumber;
            if (secondNumber > max)
            {
                max = secondNumber;
                if (thirdNumber > max)
                {
                    max = thirdNumber;
                }
            }
            Console.WriteLine("The max is: ");
            Console.WriteLine(max);
        }
    }
}
