// We are given the following sequence:
// S1 = N;
// S2 = S1 + 1;
// S3 = 2*S1 + 1;
// S4 = S1 + 2;
// S5 = S2 + 1;
// S6 = 2*S2 + 1;
// S7 = S2 + 2;
// ...
// Using the Queue<T> class write a program to print its first 50 members for given N.
// Example: N=2  2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...

namespace SequenceOfNumbersWithQueue
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static readonly Func<int, int>[] functions = 
        {
            x => x + 1,
            x => (2 * x) + 1,
            x => x + 2
        };

        public static void Main()
        {
            var initialNumber = 2;

            var result = GetSequenceOfNumbers(initialNumber);

            PrintResult(result);
        }

        private static List<int> GetSequenceOfNumbers(int initialNumber)
        {
            var sequence = new Queue<int>();
            var result = new List<int>() { initialNumber };

            sequence.Enqueue(initialNumber);
            for (int count = 1; count <= 50; count++)
            {
                var number = sequence.Dequeue();
                foreach (var function in functions)
                {
                    result.Add(function(number));
                    sequence.Enqueue(function(number));
                    count += 1;
                }
            }

            return result;
        }

        private static void PrintResult(List<int> result)
        {
            Console.WriteLine("The sequence is: ");
            foreach (var number in result)
            {
                Console.Write(number + " ");
            }
        }
    }
}
