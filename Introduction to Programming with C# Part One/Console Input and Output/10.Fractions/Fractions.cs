using System;

namespace _10.Fractions
{
    class Fractions
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 1.0;
            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += (1 / (double)i);
                }
                else
                {
                    sum -= (1 / (double)i);
                }
                
            }
            Console.WriteLine(sum.ToString("F3"));
        }
    }
}
