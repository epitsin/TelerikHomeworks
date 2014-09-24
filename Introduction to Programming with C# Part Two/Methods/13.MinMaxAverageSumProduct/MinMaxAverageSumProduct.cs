using System;

namespace _13.MinMaxAverageSumProduct
{
    class MinMaxAverageSumProduct
    {
        static void Min(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine(min);
        }

        static void Max(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }

        static void Average(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum/array.Length);
        }

        static void Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }

        static void Product(int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine(product);
        }

        static void Main()
        {
            int[] array = new int[] { 2, 4, 7, 1, 3, 10, 11, 5, 2 };
            Min(array);
            Max(array);
            Average(array);
            Sum(array);
            Product(array);
        }
    }
}
