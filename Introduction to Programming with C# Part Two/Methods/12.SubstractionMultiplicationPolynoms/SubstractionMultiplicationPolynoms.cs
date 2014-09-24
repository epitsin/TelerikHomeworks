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

        static void Substraction(int[] first, int[] second)
        {
            int length = first.Length;
            if (second.Length > first.Length)
            {
                length = second.Length;
            }
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i < first.Length && i > second.Length)
                {
                    result[i] -= first[i];
                }
                if (i < second.Length && i > first.Length)
                {
                    result[i] -= second[i];
                }
                else if (i < first.Length && i < second.Length)
                {
                    result[i] = first[i] - second[i];
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

        static void Multiply(int[] first, int[] second)
        {
            int length = first.Length;
            if (second.Length > first.Length)
            {
                length = second.Length;
            }
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i < first.Length && i > second.Length)
                {
                    result[i] = first[i];
                }
                if (i < second.Length && i > first.Length)
                {
                    result[i] = second[i];
                }
                else if (i < first.Length && i < second.Length)
                {
                    result[i] = first[i] * second[i];
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
            Console.WriteLine(@"Please, enter ""addition"", ""substraction"" or ""multiplication""");
            string action = Console.ReadLine();
            if (action == "addition")
            {
                Add(first, second);
            }
            else if (action == "substraction")
            {
                Substraction(first, second);
            }
            else if (action == "multiplication")
            {
                Multiply(first, second);
            }
        }
    }
}
