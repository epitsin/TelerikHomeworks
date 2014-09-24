using System;

namespace BiggerElement
{
    class BiggerElement
    {

        static void Main()
        {
            int[] array = new int[] { 3, 2, 6, -4, 5, 8, 6, 1, 2, -2, 7, -5, 12 };
            int result = FirstBiggerInteger(array);
            if (result == -1)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("The number in the array which is bigger than its neighbours is at {0} position.", result+1);
            }
        }

        static int FirstBiggerInteger(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
