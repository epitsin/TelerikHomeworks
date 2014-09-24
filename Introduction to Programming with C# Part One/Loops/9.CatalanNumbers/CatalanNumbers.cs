using System;

namespace _9.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter n: ");
            int n = int.Parse(Console.ReadLine());
            int nFactorial = 1;
            int _2nfactorial = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }
            for (int i = 1; i <= 2*n; i++)
            {
                _2nfactorial *= i;
            }
            Console.WriteLine("The Catalan number is: ");
            Console.WriteLine((double)_2nfactorial/(nFactorial*nFactorial*(n+1)));
        }
    }
}
