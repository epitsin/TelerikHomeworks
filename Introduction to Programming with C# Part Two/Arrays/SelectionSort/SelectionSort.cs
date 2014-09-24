//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

using System;

namespace SelectionSort
{
    class SelectionSort
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
            int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
