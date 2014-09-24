using System;

namespace _3.MinAndMaxOfNnumbers
{
    class MinAndMaxOfNnumbes
    {
        static void Main()
        {
            Console.WriteLine("Please, enter how many numbers is your sequence: ");
            int n = int.Parse(Console.ReadLine());
            double min = 0;
            double max = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please, enter a number: ");
                double number = double.Parse(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                }
                else if (number > max)
                {

                    max = number;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Min is " + min);
            Console.WriteLine("Max is " + max);
        }
    }
}
