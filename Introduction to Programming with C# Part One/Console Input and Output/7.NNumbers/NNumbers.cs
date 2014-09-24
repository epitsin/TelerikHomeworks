using System;

namespace _7.NNumbers
{
    class NNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please, enter the a number: ");
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine("The sum is: " + sum);
        }
    }
}
