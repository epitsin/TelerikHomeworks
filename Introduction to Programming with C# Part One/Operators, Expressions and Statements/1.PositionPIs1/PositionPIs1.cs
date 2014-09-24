using System;

namespace PositionPIs1
{
    class PositionPIs1
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter position p: ");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int numberAndMask = number & mask;
            int result = numberAndMask >> p;
            bool bit1 = (result==1);
            Console.WriteLine("The bit at position p is 1. " + bit1);
        }
    }
}
