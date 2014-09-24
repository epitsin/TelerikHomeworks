using System;
namespace _7.PrimeNumber
{
    class PrimeNumber
    {
        static void Main()
        {
            // First method

            int number = int.Parse(Console.ReadLine());
            // First, we need to check if the number can be divided only by other prime numbers.
            // Second, we need to divide it by a number which no bigger than the square root of the number.

            if (number % 2 != 0)
            {
                if (number % 3 != 0)
                {
                    if (number % 5 != 0)
                    {
                        if (number % 7 != 0)
                        {
                            Console.WriteLine("This number is prime.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("This number is not prime.");
            }
            // Second number
            int n = int.Parse(Console.ReadLine());
            string result = (n == 2 || n == 3 || n == 5 || n == 7 || (n <= 100 && n > 7 && n % 2 != 0 && n % 3 != 0 && n % 5 != 0 && n % 7 != 0)) ? "YES" : "NOT";
        }
    }

}
