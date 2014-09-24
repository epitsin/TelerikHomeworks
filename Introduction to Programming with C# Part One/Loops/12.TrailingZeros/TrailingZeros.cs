using System;

namespace _12.TrailingZeros
{
    class TrailingZeros
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int nFactorial = 1;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }
            while (true)
            {
                if (nFactorial % 10 == 0)
                {
                    count++;
                    nFactorial = nFactorial / 10;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("The number of 0s is: ");
            Console.WriteLine(count);
        }
    }
}
