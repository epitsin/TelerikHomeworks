using System;

namespace _4.CountOfNumbers
{
    class CountOfNumbers
    {
        static int Count(int[] someArray, int number)
        {
            int count = 0;
            for (int i = 0; i < someArray.Length; i++)
            {
                if (someArray[i] == number)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main()
        {
            int[] array = new int[] { 2, 4, 7, 1, 3, 10, 11, 5, 2 };

            //Console.WriteLine("Please, enter a number from the array: ");
            //int wantedNumber = int.Parse(Console.ReadLine());
            int wantedNumber = 2;

            Console.WriteLine("The count of {0} in the array is {1} times.", wantedNumber, Count(array, wantedNumber)); 

        }
    }
}
