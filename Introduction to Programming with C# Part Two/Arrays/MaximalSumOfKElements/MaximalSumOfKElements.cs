//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

using System;
using System.Collections.Generic;

namespace MaximalSumOfKElements
{
    class MaximalSumOfKElements
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
            //Console.WriteLine("Please, enter the number K: ");
            //int k = int.Parse(Console.ReadLine());

            int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int k = 4;

            int maxSum = 0;
            string maxSub = String.Empty;
            for (int i = 1; i < Math.Pow(2,array.Length); i++)
            {
                string binary = Convert.ToString(i, 2).PadLeft(array.Length,'0');
                int sum = 0;
                int countOfNumbersTaken = 0;
                string sub = String.Empty;
                for (int j = 0; j < binary.Length; j++)
                {
                    if (binary[j] == '1')
                    {
                        sum += array[j];
                        countOfNumbersTaken++;
                        sub += array[j] + " ";
                    }
                }
                if (countOfNumbersTaken==k && sum > maxSum)
                {
                    maxSum = sum;
                    maxSub = sub;
                }
            }

            Console.WriteLine("The maximum sum is: {0}", maxSum);
            Console.WriteLine("And the sequence is: {0}", maxSub);
        }
    }
}
