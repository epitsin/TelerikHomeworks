using System;

namespace _4.DIvisionBy5
{
    class DivisionBy5
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the second number: ");
            int second = int.Parse(Console.ReadLine());
            int count = 0;
            int min = first;
            if (min > second)
            {
                min = second;
            }
            int max = first;
            if (max < second)
            {
                max = second;
            }
            for (int i = min; i <= max; i++)
            {
                if (i%5==0)
                {
                    count = count +1;
                }
            }
            Console.WriteLine("The numbers that can be divided by 5 are: " + count);
        }
    }
}
