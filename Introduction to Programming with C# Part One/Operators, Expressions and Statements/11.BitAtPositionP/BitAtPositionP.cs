using System;

namespace BitAtPositionP
{
    class BitAtPositionP
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
            Console.WriteLine("The bit at position p is: " + result);
        }
    }
}