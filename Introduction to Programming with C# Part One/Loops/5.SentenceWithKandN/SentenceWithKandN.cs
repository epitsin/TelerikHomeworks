using System;

namespace _5.SentenceWithKandN
{
    class SentenceWithKandN
    {
        static void Main()
        {
            Console.WriteLine("Please, enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter k: ");
            int k = int.Parse(Console.ReadLine());
            int nFactorial = 1;
            int kFactorial = 1;
            int knFactorial = 1;
            if (n > 1 && k > n)
            {
                for (int i = 1; i <= n; i++)
                {
                    nFactorial *= i;
                }
                for (int i = 1; i <= k; i++)
                {
                    kFactorial *= i;
                }
                for (int i = 1; i <= (k - n); i++)
                {
                    knFactorial *= i;
                }
                Console.WriteLine("The result is: ");
                Console.WriteLine(nFactorial * kFactorial / knFactorial);
            }
            else
            {
                Console.WriteLine("Invalid numbers.");
            }
        }
    }
}
