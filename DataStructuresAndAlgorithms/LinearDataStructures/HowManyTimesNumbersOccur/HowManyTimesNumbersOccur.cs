// Write a program that finds in given array of integers (all belonging to the range [0..1000]) 
// how many times each of them occurs.
// Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
// 2  2 times
// 3  4 times
// 4  3 times

namespace HowManyTimesNumbersOccur
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HowManyTimesNumbersOccur
    {
        public static void Main()
        {
            var listOfNumbers = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            Console.WriteLine("The original numbers are: " + string.Join(" ", listOfNumbers));

            var occurrences = listOfNumbers.GroupBy(x => x);

            PrintResult(occurrences);
        }

        private static void PrintResult(IEnumerable<IGrouping<int, int>> occurrences)
        {
            foreach (var number in occurrences)
            {
                Console.WriteLine(number.Key + " -> " + number.Count() + " times");
            }
        }
    }
}
