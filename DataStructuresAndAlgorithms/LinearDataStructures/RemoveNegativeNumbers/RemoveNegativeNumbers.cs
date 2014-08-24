// Write a program that removes from given sequence all negative numbers.

namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativeNumbers
    {
        public static void Main()
        {
            var listOfNumbers = new List<int>() { 1, -2, -5, -3, -3, 2, 2, 1, -4, 4 };

            Console.WriteLine("The original numbers are: " + string.Join(" ", listOfNumbers));

            listOfNumbers.RemoveAll(x => x < 0);

            Console.WriteLine("Only positive numbers: " + string.Join(" ", listOfNumbers));
        }
    }
}
