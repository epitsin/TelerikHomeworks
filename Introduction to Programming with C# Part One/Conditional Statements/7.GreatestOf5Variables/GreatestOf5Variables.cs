using System;

namespace _7.GreatestOf5Variables
{
    class GreatestOf5Variables
    {
        static void Main()
        {
            Console.WriteLine("Please,enter how many numbers you will have: ");
            int count = int.Parse(Console.ReadLine());
            double max = 0;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Please, enter a number: ");
                double number = double.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
        }
    }
}
