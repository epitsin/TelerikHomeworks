using System;
using System.Collections.Generic;

namespace _8.StringSOrting
{
    class StringSorting
    {
        static void Main()
        {
            string[] array = { "a", "aaaaa", "aaaawasdawd", "a", "12355asdf", "wdasdwe" };

            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
