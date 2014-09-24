// Write a program that finds the maximal sequence of equal elements in an array.

using System;

namespace MaximumSequenceOfElements
{
    class MaximumSequenceOfElements
    {
        static void Main()
        {
            //Console.WriteLine("Please, enter the length of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Please, enthe the {0} element: ", i+1);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            int[] array = new int[] { 2, 2, -6, -1, 2, -1, 4, 4, 4, 8 };

            int maxCount = 0;
            int index = 0;
            try
            {
                int count = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == array[i + 1])
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
                        index = array[i];
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The max length of equal elements is: " + maxCount);
                Console.WriteLine("And the sequence is: {0}", new string(Convert.ToChar(index.ToString()), maxCount));
            }
        }
    }
}
