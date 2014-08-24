// * The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times. 
// Write a program to find the majorant of given array (if exists). 
// Example:
// {2, 2, 3, 3, 2, 3, 4, 3, 3}  3

namespace MajorantInArrayOfNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MajorantInArrayOfNumbers
    {
        public static void Main()
        {
            var listOfNumbers = new List<int>() { 5, 5, 2, 2, 3, 3, 2, 3, 4, 3, 3, 5, 5, 5 };

            Console.WriteLine("The original numbers are: " + string.Join(" ", listOfNumbers));

            var majorants = listOfNumbers.GroupBy(x => x).Where(x => x.Count() >= (listOfNumbers.Count / 2) + 1);

            PrintResult(majorants);
        }

        private static void PrintResult(IEnumerable<IGrouping<int, int>> majorants)
        {
            Console.WriteLine("The majorant is: ");
            foreach (var majorant in majorants)
            {
                Console.WriteLine(majorant.Key);
            }
        }
    }
}
