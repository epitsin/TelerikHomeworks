//* Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;

namespace SubsetOfKElementsAndSumS
{
    class SubsetOfKElementsAndSumS
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

            Console.WriteLine("Please, enter the number of the elements in the sum: ");
            int k = int.Parse(Console.ReadLine());

            bool sequenceFound = false;
            string maxSub = String.Empty;
            for (int i = 1; i < Math.Pow(2, array.Length); i++)
            {
                string binary = Convert.ToString(i, 2).PadLeft(array.Length, '0');
                int sum = 0;
                int countOfNumbersTaken = 0;
                string sub = String.Empty;
                for (int j = 0; j < binary.Length; j++)
                {
                    if (binary[j] == '1')
                    {
                        sum += array[j];
                        sub += array[j] + " ";
                        countOfNumbersTaken++;
                    }
                }
                if (countOfNumbersTaken == k && sum == maxSum)
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
