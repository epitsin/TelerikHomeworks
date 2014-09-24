//Write a program that finds the sequence of maximal sum in given array. Example:
//    {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}

using System;
using System.Linq;

namespace MaximumSumOfSequence
{
    class MaximumSumOfSequence
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

            int[] arr = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            var res =
                from index in Enumerable.Range(0, arr.Length) // taking all starting indexes in the array
                from length in Enumerable.Range(1, arr.Length - index) // initializing all possible lengths of subsums
                let subset = arr.Skip(index).Take(length) // making subarrays
                orderby subset.Count() // ordering them by count because we need the shortest subarray (ascending by default)
                orderby subset.Sum() descending // ordering them by summing the elements in the subarrays
                select subset;
            var final = res.First(); // taking the first element which also has the biggest sum and the least elements

            foreach (var item in final)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }
    }
}
