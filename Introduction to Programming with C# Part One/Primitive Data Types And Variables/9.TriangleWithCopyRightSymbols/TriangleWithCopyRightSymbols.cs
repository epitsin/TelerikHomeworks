using System;
using System.Linq;

namespace _9.TriangleWithCopyRightSymbols
{
    class TriangleWithCopyRightSymbols
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the number of rows you would like to have."); // For example, 3 rows are 9 symbols.
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                Console.Write(new String(' ', (rows - i))); // Here we print the space (rows - 1) times.
                Console.Write(new String('©', (2 * i - 1)));
                Console.WriteLine();
            }
        }
    }
}
