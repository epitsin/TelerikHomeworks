using System;

namespace _3.ThirdLection_5._11._2013
{
    class OddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Your number is even.");
            }
            else
            {
                Console.WriteLine("Your number is odd.");
            }
        }
    }
}
