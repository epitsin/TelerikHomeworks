namespace FactorsOfNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static readonly List<string> allPermutations = new List<string>();

        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var numbers = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            GetCombinationsWithDuplicates(numbers, new List<int>(), 0);

            int min = int.MaxValue;
            long minPermutation = 0;
            foreach (var permutation in allPermutations)
            {
                var currentNumber = int.Parse(permutation);
                var factors = GetFactors(currentNumber);
                if (min > factors)
                {
                    min = factors;
                    minPermutation = currentNumber;
                }
                else if (min == factors)
                {
                    if (currentNumber < minPermutation)
                    {
                        minPermutation = currentNumber;
                    }
                }
            }

            Console.WriteLine(minPermutation);
        }

        private static int GetFactors(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; ++i)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static void GetCombinationsWithDuplicates(int[] numbers, List<int> result, int count)
        {
            if (count >= numbers.Length)
            {
                var numbersAsString = string.Join("", result);
                if (!allPermutations.Contains(numbersAsString))
                {
                    allPermutations.Add(numbersAsString);
                }

                return;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];
                var countOfInitialNums = numbers.Where(x => x == currentNumber).Count();
                var countOfCurrentNums = result.Where(x => x == currentNumber).Count() + 1;

                if (countOfInitialNums >= countOfCurrentNums)
                {
                    result.Add(numbers[i]);
                }
                else
                {
                    continue;
                }

                GetCombinationsWithDuplicates(numbers, result, count + 1);

                result.RemoveAt(count);
            }
        }
    }
}
