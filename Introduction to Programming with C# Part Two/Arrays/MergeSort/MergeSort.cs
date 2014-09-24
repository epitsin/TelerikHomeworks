//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

namespace MergeSort
{
    class MergeSort
    {
        static int[] DivideLeftRight(int[] array)
        {
            if (array.Length < 2)
            {
                return array;
            }

            int[] left = new int[array.Length/2];
            for (int i = 0; i < left.Length; i++)
            {
                left[i] = array[i];
            }

            int[] right = new int[array.Length - left.Length];
            int j = 0;
            for (int i = array.Length / 2; i < array.Length; i++)
            {
                right[j] = array[i];
                j++;
            }

            DivideLeftRight(left);
            DivideLeftRight(right);
            return Merge(left, right, array);
        }

        static int[] Merge(int[] left, int[] right, int[] array)
        {
            int i = 0, j = 0, m = 0;
            while (i<left.Length || j<right.Length)
            {
                if (i<left.Length && j<right.Length)
                {
                    if (left[i] < right[j])
                    {
                        array[m] = left[i];
                        m++;
                        i++;
                    }
                    else
                    {
                        array[m] = right[j];
                        m++;
                        j++;
                    }
                }
                else if (i >= left.Length || j < right.Length)
                {
                    array[m] = right[j];
                    m++;
                    j++;
                }
                    
                
                else
                {
                    array[m] = left[i];
                    m++;
                    i++;
                }
            }
            return array;
        }

        static void Main()
        {
            int[] array = new int[] { 5, 2, 6, 8, 1, 3, 6, 4, 0, 9 };
            int[] combined = DivideLeftRight(array);
            foreach (var item in combined)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
