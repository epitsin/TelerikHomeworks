using System;

namespace N_dividedByK_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter k: ");
            int k = int.Parse(Console.ReadLine());
            int nFactorial = 1;
            int kFactorial = 1;
            if (k > 1 && n > k)
            {
                for (int i = 1; i <= n; i++)
                {
                    nFactorial = nFactorial * i;
                }
                for (int j = 1; j <= k; j++)
                {
                    kFactorial = kFactorial * j;
                }
            }
            else
            {
                Console.WriteLine("Invalid numbers.");
            }
            Console.WriteLine(nFactorial/kFactorial);
        }
    }
}
