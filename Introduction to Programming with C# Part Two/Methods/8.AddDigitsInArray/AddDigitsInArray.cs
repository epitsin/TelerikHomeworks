using System;

namespace _8.AddDigitsInArray
{
    class AddDigitsInArray
    {
        static void AddNumbers(int[] array1, int[] array2)
        {
            int length = array2.Length;
            if (array1.Length > array2.Length)
            {
                length = array1.Length;
            }
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i < array1.Length)
                {
                    result[i] += array1[i];
                }
                if (i < array2.Length)
                {
                    result[i] += array2[i];
                }
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int[] firstArray = new int[] { 1, 3, 5, 7, 9 };
            Array.Reverse(firstArray);
            int[] secondArray = new int[] { 2, 4, 6, 8, 10 };
            Array.Reverse(secondArray);
            AddNumbers(firstArray, secondArray);
        }
    }
}
