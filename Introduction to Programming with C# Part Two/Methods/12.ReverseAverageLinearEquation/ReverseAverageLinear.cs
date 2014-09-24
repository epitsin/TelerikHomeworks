using System;
using System.Collections.Generic;

namespace _12.ReverseAverageLinearEquation
{
    class ReverseAverageLinear
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please, enter 'a' for reversing the digits of a number. \nPlease, enter 'b' for calculating the average of a sequence of numbers. \nPlease, enter 'c' for solving a linear equation. ");
                string input = Console.ReadLine();

                if (input == "a")
                {
                    decimal n = 0;
                    ReadInput(n);
                    break;
                }
                else if (input == "b")
                {
                    List<int> array = new List<int>();
                    ReadInput(array);
                    break;
                }
                else if (input == "c")
                {
                    int a = 0;
                    int b = 0;
                    LinearEquation(a, b);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        static void ReadInput(decimal n)
        {
            Console.WriteLine("Please, enter a number: ");
            n = int.Parse(Console.ReadLine());
            ReverseDigits(n);
        }

        static void ReadInput(List<int> array)
        {
            Console.WriteLine("Please, enter the length of your sequence: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please, enter the {0} number: ", i+1);
                array.Add(int.Parse(Console.ReadLine()));
            }
            AverageOfSequence(array);
        }

        static void ReadInput(int a, int b)
        {
            Console.WriteLine("Please, enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter b: ");
            b = int.Parse(Console.ReadLine());
            LinearEquation(a, b);
        }

        static void ReverseDigits(decimal n)
        {
            string rev = "";
            while (n != 0)
            {
                rev += n % 10;
                n /= 10;
            }
            Console.WriteLine(rev);
        }

        static void AverageOfSequence (List<int> array)
        {
            long sum = 0L;
            for (int i = 0; i < array.Count; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum/array.Count);
        }

        static void LinearEquation(int a, int b)
        {
            Console.WriteLine("X = " + (-b/a));
        }
    }
}
