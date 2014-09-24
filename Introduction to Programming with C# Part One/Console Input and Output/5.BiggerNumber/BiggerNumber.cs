using System;

namespace _5.BiggerNumber
{
    class BiggerNumber
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            int result = (a > b) ? a : b;
            Console.WriteLine("The bigger number is: " + result);
        }
    }
}
