using System;

namespace _6.NumbersNandX
{
    class NumbersNandX
    {
        static void Main()
        {
            Console.WriteLine("Please, enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter x: ");
            int x = int.Parse(Console.ReadLine());
            int nFactorial = 1;
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
                result += (double)nFactorial / (Math.Pow(x,i));
            }
            Console.WriteLine("The result is: ");
            Console.WriteLine(result + 1);
        }
    }
}
