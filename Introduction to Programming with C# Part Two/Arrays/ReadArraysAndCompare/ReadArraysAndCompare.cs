//Write a program that reads two arrays from the console and compares them element by element.


using System;

namespace ReadArraysAndCompare
{
    class ReadArraysAndCompare
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the number of elements in the first array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please, enter element number {0} of the first array: ", (i+1));
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please, enter the number of elements in the second array: ");
            int m = int.Parse(Console.ReadLine());
            bool different = false;
            if (m != n)
            {
                Console.WriteLine("The length of the arrays is different therefore the two array cannot be compared!");
                different = true;
            }
            if (!different)
            {
                int[] array2 = new int[m];
                for (int i = 0; i < m; i++)
                {
                    Console.WriteLine("Please, enter element number {0} of the second array: ", (i + 1));
                    array2[i] = int.Parse(Console.ReadLine());
                    if (array1[i] != array2[i])
                    {
                        different = true;
                    }
                }
                if (different)
                {
                    Console.WriteLine("The two arrays are different!");
                }
                else
                {
                    Console.WriteLine("The two arrays are the same!");
                }
            }
        }
    }
}
