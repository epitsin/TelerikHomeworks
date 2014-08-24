// Write a method that finds the longest subsequence of equal numbers in given List<int> and 
// returns the result as new List<int>. Write a program to test whether the method works correctly.

namespace LongestSubsequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestSubsequenceOfEqualNumbers
    {
        public static void Main()
        {
            var listOfNumbres = new List<int>() { 1, 2, 2, 5, 5, 3, 3, 3, 2, 2, 1, 4, 4 };
            var longestSunsequence = GetLongestSubsequenceOfNumbers(listOfNumbres);

            Console.WriteLine("The original numbers are: " + string.Join(" ", listOfNumbres));
            Console.WriteLine("The longest sequence of equal numbers is: " + string.Join(" ", longestSunsequence));
        }

        private static IList<int> GetLongestSubsequenceOfNumbers(IList<int> listOfNumbres)
        {
            if (listOfNumbres.Count == 0)
            {
                throw new ArgumentNullException("The list is empty!");
            }

            var element = listOfNumbres[0];
            var countOfElements = 1;

            for (int i = 0; i < listOfNumbres.Count; i++)
            {
                var currentElement = listOfNumbres[i];
                var currentCount = 1;
                while (i + 1 < listOfNumbres.Count && listOfNumbres[i + 1] == currentElement)
                {
                    currentCount++;
                    i++;
                }

                if (currentCount > countOfElements)
                {
                    element = currentElement;
                    countOfElements = currentCount;
                }
            }

            var result = Enumerable.Repeat(element, countOfElements).ToList();

            return result;
        }
    }
}
