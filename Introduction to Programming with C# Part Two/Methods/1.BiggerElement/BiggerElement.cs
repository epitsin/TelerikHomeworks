using System;

namespace BiggerElement
{
    class BiggerElement
    {

        static void Main()
        {
            int[] array = new int[] { 3, 2, 6, -4, 5, 8, 6, 1, 2, -2, 7, -5, 12 };
            Console.WriteLine("Please, enter an index: ");
            int elementIndex = int.Parse(Console.ReadLine());

            ValidNumber(array, elementIndex);

            if (BiggerIntegerThanNeighbours(array, elementIndex))
            {
                Console.WriteLine("The number at position {0}: {1} is bigger than its neighbours.", elementIndex, array[elementIndex]);
            }
            else
            {
                Console.WriteLine("The number at position {0}: {1} is NOT bigger than its neighbours.", elementIndex, array[elementIndex]);
            }
        }

        static void ValidNumber(int[] array, int elementIndex)
        {
            if (elementIndex == 0 || elementIndex == array.Length - 1)
            {
                Console.WriteLine("The element at this position doesn't have 2 neighbours or is outside the boudaries of the array.");
            }
        }

        static bool BiggerIntegerThanNeighbours(int[] array, int elementIndex)
        {
            if (array[elementIndex] > array[elementIndex - 1] && array[elementIndex] > array[elementIndex + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
