using System;

namespace _2.GetMax
{
    class GetMax
    {
        static double GetMaxValue(double a, double b)
        {
            double max = a;
            if (b > max)
            {
                max = b;
            }
            return max;
        }

        static void Main()
        {
            Console.WriteLine("Please, enter 3 numbers: ");
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(GetMaxValue(GetMaxValue(firstNumber, secondNumber), thirdNumber)); 
        }
    }
}
