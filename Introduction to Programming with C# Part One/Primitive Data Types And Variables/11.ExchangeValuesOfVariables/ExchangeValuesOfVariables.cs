using System;

namespace _11.ExchangeValuesOfVariables
{
    class ExchangeValuesOfVariables
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int m = firstNumber;
            firstNumber = secondNumber;
            secondNumber = m;
            Console.WriteLine("After exchanging values: \n first number = {0} \n second number = {1}", firstNumber, secondNumber);
        }
    }
}
