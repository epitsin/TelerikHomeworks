using System;
namespace _11.AddPolynoms
{
    class AddPolynoms
    {
        static void Add(int[] first, int[] second)
        {
            int length = first.Length;
            if (second.Length > first.Length)
            {
                length = second.Length;
            }
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i < first.Length)
                {
                    result[i] += first[i];
                }
                if (i < second.Length)
                {
                    result[i] += second[i];
                }
            }
            for (int i = 0; i < length; i++)
            {
                if (i != length - 1)
                {
                    Console.Write("{0}*x^{1} + ", result[i], length - i);
                }
                else
                {
                    Console.Write("{0}*x^{1}", result[i], length - i);
                }
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int[] first = new int[] { 5, 0, 1 };
            int[] second = new int[] { 2, 4, 6 };

            Add(first, second);
        }
    }
}
