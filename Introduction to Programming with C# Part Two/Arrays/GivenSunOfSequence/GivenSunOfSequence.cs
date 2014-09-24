//Write a program that finds in given array of integers a sequence of given sum S (if present). 
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}

using System;
using System.Collections.Generic;
using System.Linq;

namespace GivenSunOfSequence
{
    class GivenSunOfSequence
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
            //Console.WriteLine("Please, enter the desired sum: ");
            //int sum = int.Parse(Console.Readline());

            var array = new []{ 4, 3, 1, 4, 2, 5, 8 };
            int sum = 11;

            // First method
            var res =
                from index in Enumerable.Range(0, array.Length) // taking all starting indexes in the array
                from length in Enumerable.Range(1, array.Length - index) // initializing all possible lengths of subsums
                let subset = array.Skip(index).Take(length) // making subarrays
                select subset;

            foreach (var item in res)
            {
                int currentSum = item.Sum();
                if (currentSum == sum)
                {
                    Console.WriteLine("The sequence is: ");
                    foreach (var value in item)
                    {
                        Console.Write("{0} ", value);
                    }
                    Console.WriteLine();
                }
            }

            // Second method
            int currSum = 0;
            int count = 1;
            int maxCount = 1;
            bool breakCycles = false;
            List<int> subArray = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                currSum = array[i];
                subArray.Add(array[i]);
                if (currSum != sum)
                {

                    for (int j = i + 1; j < array.Length; j++)
                    {
                        subArray.Add(array[j]);
                        if (currSum + array[j] == sum)
                        {
                            count += 1;
                            maxCount = count;

                            breakCycles = true;
                            break;
                        }

                        else if (array[j] + currSum < sum)
                        {
                            currSum += array[j];
                            count += 1;
                            continue;
                        }
                        else
                        {
                            count = 1;
                            subArray.Clear();
                            break;
                        }
                    }
                }
                if (breakCycles == true)
                {
                    break;
                }
            }

            Console.WriteLine("The sequence is: ");
            foreach (int value in subArray)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();
        }
    }
}
