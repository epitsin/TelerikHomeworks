//Write a program that finds the most frequent number in an array. Example:
//    {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

using System;
using System.Linq;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {
            //Console.WriteLine("Please, enter the length N of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine("Please, enthe the {0} element: ", i + 1);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            int[] arr = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            //First method
            int maxCount = 0;
            int element = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    element = arr[i];
                }
            }

            Console.WriteLine("The most frequent number is {0} -> {1} times.", element, maxCount);

            // Second method
            var frequncy =
                from fr in arr
                group fr by fr into count
                orderby count.Count() descending
                select count;

            var mostFrequent = frequncy.First();
            Console.WriteLine("The most frequent number is {0} -> {1} times.", mostFrequent.ElementAt(0), mostFrequent.Count());
        }
    }
}
