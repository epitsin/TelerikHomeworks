using System;

namespace _7.BinarySearchWithK
{
    class BinarySearchWithK
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
			{
                array[i] = int.Parse(Console.ReadLine());
			}
            Console.WriteLine("Enter the number to compare with: ");
            int k = int.Parse(Console.ReadLine());
            Array.Sort(array);
            int start = 0;
            int end = array.Length - 1;
            int middle = array.Length / 2;
            int maxNumber = 0;
            while (true)
            {
                if (k > array[middle] && middle!=start)
                {
                    start = middle;
                    middle = (end + start) / 2;
                }
                else if (k < array[middle] && middle!=start)
                {
                    end = middle;
                    middle = (end + start) / 2;

                }
                else
                {
                    maxNumber = array[middle];
                    break;
                }
            }
            Console.WriteLine("The largest number in the array which is ≤ K is: {0}.", maxNumber);
        }
    }
}
