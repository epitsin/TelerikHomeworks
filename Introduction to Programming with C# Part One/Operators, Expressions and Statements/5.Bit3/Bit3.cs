using System;

namespace _5.Bit3
{
    class Bit3
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int mask = 1 << 2;
            int numberAndMask = number & mask;
            int result = numberAndMask >> 2;
            Console.WriteLine("The third bit of your number is: " + result);
        }
    }
}
