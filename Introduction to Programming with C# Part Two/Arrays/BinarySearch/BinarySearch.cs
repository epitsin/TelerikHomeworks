//Write a program that finds the index of given element in a sorted array of integers 
//by using the binary search algorithm (find it in Wikipedia).

using System;

namespace BinarySearch
{
    class BinarySearch
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

            var array = new[] { 4, 3, 1, 4, 2, 5, 8 };
            Array.Sort(array);

            Console.WriteLine("Please, enter an element from the array: ");
            int value = int.Parse(Console.ReadLine());

            int start = 0;
            int final = array.Length - 1;
            int middle = (final + start) / 2;

            while (true)
            {
                if (value < array[middle])
                {
                    final = middle;
                    middle = (final + start) / 2;
                }
                else if (value > array[middle])
                {
                    start = middle;
                    middle = (final + start) / 2;
                }
                else
                {
                    Console.WriteLine("{0} is at position {1}.", value, middle);
                    break;
                }

                if (middle == final || middle == start)
                {
                    if (value == array[final])
                    {
                        Console.WriteLine("{0} is at position {1}.", value, final);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("{0} is at position {1}.", value, start);
                        break;
                    }
                }
            }
        }
    }
}
