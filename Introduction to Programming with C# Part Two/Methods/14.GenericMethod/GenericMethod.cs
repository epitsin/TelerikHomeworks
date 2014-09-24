using System;

namespace _13.MinMaxAverageSumProduct
{
    class MinMaxAverageSumProduct
    {
        static void Min<T>(params T[] array)
        {
            dynamic min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine(min);
        }

        static void Max<T>(params T[] array)
        {
            dynamic max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }

        static void Average<T>(params T[] array)
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum / array.Length);
        }

        static void Sum<T>(params T[] array)
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }

        static void Product<T>(params T[] array)
        {
            dynamic product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            Console.WriteLine(product);
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Min(array);
            Max(array);
            Average(array);
            Sum(array);
            Product(array);
        }
    }
}
