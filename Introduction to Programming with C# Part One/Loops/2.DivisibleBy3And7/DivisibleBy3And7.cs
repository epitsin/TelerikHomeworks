using System;

namespace _2.DivisibleBy3And7
{
    class DivisibleBy3And7
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers that are not divisible by 3 and 7 are: ");
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
