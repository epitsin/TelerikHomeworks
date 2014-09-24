using System;
namespace _4.ThirdDigit7
{
    class ThirdDigit7
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number which has at least 3 digits: ");
            int number = 0;
            while (true)
            {
                number = int.Parse(Console.ReadLine()); // Here we check is the number has at least 3 digits.
                if (number > 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please, enter a number which has at least 3 digits: ");
                }
            }
            for (int i = 0; i < 2; i++)
            {
                number = number / 10;
            }
            if (number % 10 == 7)
            {
                Console.WriteLine("The 3rd digit is 7.");
            }
            else
            {
                Console.WriteLine("The 3rd digit is not 7.");
            }
        }
    }
}
