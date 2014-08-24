// Write a program that removes from given sequence all numbers that occur odd number of times. 
// Example:
// {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}  {5, 3, 3, 5}

namespace NumbersOccuringOddNumberOfTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NumbersOccuringOddNumberOfTimes
    {
        public static void Main()
        {
            var listOfNumbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            Console.WriteLine("The original numbers are: " + string.Join(" ", listOfNumbers));

            var evenNumberOfOccurrences = FindEvenOccurences(listOfNumbers);

            var listOfOddOccurrences = listOfNumbers.Where(e => evenNumberOfOccurrences.Contains(e));
            Console.WriteLine("Only the numbers that occur even number of times: " + string.Join(" ", listOfOddOccurrences));
        }

        private static HashSet<int> FindEvenOccurences(List<int> listOfNumbers)
        {
            var oddNumberOfOccurrences = new HashSet<int>();
            var evenNumberOfOccurrences = new HashSet<int>();

            foreach (var number in listOfNumbers)
            {
                if (oddNumberOfOccurrences.Add(number))
                {
                    evenNumberOfOccurrences.Remove(number);
                }
                else
                {
                    oddNumberOfOccurrences.Remove(number);
                    evenNumberOfOccurrences.Add(number);
                }
            }

            return evenNumberOfOccurrences;
        }
    }
}
