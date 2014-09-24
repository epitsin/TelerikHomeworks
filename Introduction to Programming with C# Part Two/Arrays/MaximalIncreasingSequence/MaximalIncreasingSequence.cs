// Write a program that finds the maximal increasing sequence in an array. 

using System;

namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            //Console.WriteLine("Please, enter the length of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Please, enthe the {0} element: ", i + 1);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int maxCount = 0;
            int index = 0;
            try
            {
                int count = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] + 1 == array[i + 1])
                    {
                        count += 1;
                    }
                    else
                    {
                        count = 1;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        index = array[i + 1];
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The max length of increasing elements is: " + maxCount);
                Console.Write("And the sequence is: ");
                for (int i = index - maxCount + 1; i <= index; i++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
        }
    }
}
