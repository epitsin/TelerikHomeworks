using System;

namespace _2.ProductOfRealNumbers
{
    class ProductOfRealNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter 2 numbers: ");
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            Console.WriteLine("The product of the 2 numbers is: ");
            if (((first > 0) && (second > 0)) || ((first < 0) && (second < 0)))
            {
                Console.WriteLine("+");
            }
            else if ((first < 0) ^ (second < 0))
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
            
        }
    }
}
