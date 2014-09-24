using System;

namespace _9._1.SortAnArrayInAscendingOrder
{
    class SortAnArrayInAscendingOrder
    {
        static void FindMin(int[] array, int index)
        {
            int min = array[index];
            for (int i = index + 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    array[index] = array[i];
                    array[i] = min;
                    min = array[index];
                }
            }
        }

        static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                FindMin(array, i);
            }
        }
        static void Main()
        {
            int[] array = new int[] { 2, 4, 6, 3, 5, 7, 1, 8, 4, 2, 6, 9, 4, 10 };
            SortArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i]);
            }
        }
    }
}
