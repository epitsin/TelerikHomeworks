using System;

namespace _10.NFactorial
{
    class NFactorial
    {
        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * (Factorial(n - 1));
            }
        }

        static void Main()
        {
            Console.WriteLine("Please, enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
    }
}
