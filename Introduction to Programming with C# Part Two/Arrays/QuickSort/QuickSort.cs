//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

namespace QuickSort
{
    class QuickSort
    {
        static List<string> Divide(List<string> array)
        {
            if (array.Count < 2)
            {
                return array;
            }

            List<string> left = new List<string>();
            List<string> right = new List<string>();
            string pivot = array[array.Count / 2];
            array.Remove(pivot);
            foreach (var item in array)
            {
                if (string.Compare(item,pivot) == -1)
                {
                    left.Add(item);
                }
                else
                {
                    right.Add(item);
                }
            }
            List<string> result = new List<string>();
            result.AddRange(Divide(left));
            result.Add(pivot);
            result.AddRange(Divide(right));
            return result;
        }

        static void Main()
        {
            List<string> array = new List<string> {"abd", "fg", "tjhty", "ser", "sedf", "rthyy", "aer", "rfv", "aefr", "sdf" };
            List<string> combined = Divide(array);
            foreach (var item in combined)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

    }
}
