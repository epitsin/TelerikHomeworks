//* We are given an array of integers and a number S. 
//Write a program to find if there exists a subset of the elements of the array that has a sum S. 
//Example:
//    arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)

using System;

namespace SubsetSum
{
    class SubsetSum
    {
        static void Main()
        {
            //Console.WriteLine("Please, enter the length N of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Please, enthe the {0} element: ", i + 1);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            int[] array = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };

            Console.WriteLine("Please, enter the sum of the elements: ");
            int maxSum = int.Parse(Console.ReadLine());

            bool sequenceFound = false;
            string maxSub = String.Empty;
            for (int i = 1; i < Math.Pow(2, array.Length); i++)
            {
                string binary = Convert.ToString(i, 2).PadLeft(array.Length, '0');
                int sum = 0;
                string sub = String.Empty;
                for (int j = 0; j < binary.Length; j++)
                {
                    if (binary[j] == '1')
                    {
                        sum += array[j];
                        sub += array[j] + " ";
                    }
                }
                if (sum == maxSum)
                {
                    maxSub = sub;
                    Console.WriteLine("Sequence with sum {0} is: {1}", maxSum, maxSub);
                    sequenceFound = true;
                }
            }

            if (!sequenceFound)
            {
                Console.WriteLine("Sorry, nut there is no sequence with this sum!");
            }
        }
    }
}
