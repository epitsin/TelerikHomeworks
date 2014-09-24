using System;

namespace _9.MaximalElementInPortion
{
    class MaximalElementInPortion
    {
        static void BiggestElement(int[] array, int index, int length)
        {
            int max = int.MinValue;
            for (int i = index; i < index + length && i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }

        static void Main()
        {
            int[] array = new int[] { 2, 4, 6, 3, 5, 7, 1, 8, 4, 2, 6, 9, 4, 10 };
            int index = 0;
            do
            {
                index = int.Parse(Console.ReadLine());
            }
            while (index < 0 || index >= array.Length) ;
            int length = int.Parse(Console.ReadLine());
            BiggestElement(array, index, length);
        }
    }
}
