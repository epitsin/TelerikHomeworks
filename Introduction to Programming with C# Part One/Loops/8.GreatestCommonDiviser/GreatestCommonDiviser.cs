using System;

namespace _8.GreatestCommonDiviser
{
    class GreatestCommonDiviser
    {
        static void Main()
        {
            Console.WriteLine("Please, enter 2 numbers: ");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            while (true)
            {
                if ((firstNumber % secondNumber) == 0)
                {
                    break;
                }
                    int reminder = firstNumber % secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = reminder;
            }
            Console.WriteLine("The greatest common diviser is: ");
            Console.WriteLine(secondNumber);
        }
    }
}
