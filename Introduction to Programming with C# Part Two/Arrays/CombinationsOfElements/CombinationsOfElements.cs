//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
//Example:
//    N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace CombinationsOfElements
{
    class CombinationsOfElements
    {
        static void Main()
        {
            int k = 2;
            int[] array = new int[]{ 1, 2, 3, 4, 5 };
            GetCombination(array, k);
        }

        static void GetCombination(int[] numbers, int k)
        {
            double count = Math.Pow(2, numbers.Length);
            for (int i = 1; i <= count - 1; i++)
            {
                string str = Convert.ToString(i, 2).PadLeft(numbers.Length, '0');
                if (Regex.Matches(str, "1").Count == k)
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[j] == '1')
                        {
                            Console.Write(numbers[j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
