using System;

namespace NewLines
{
    class NewLInes
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
