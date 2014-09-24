using System;

namespace _12.ModifyNtoValueV
{
    class ModifyNtoValueV
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter position p: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter value v of 1 or 0: ");
            int v = int.Parse(Console.ReadLine());
            if (v == 1)
            {
                int mask = 1 << p;
                int result = number | mask;
                Console.WriteLine("The new number is: " + result);
            }
            else
            {
                int mask = ~(1 << p);
                int result = number & mask;
                Console.WriteLine("The new number is: " + result);
            }
        }
    }
}
