// Write a program that reads N integers from the console and reverses them using a stack. 
// Use the Stack<int> class.

namespace ReadAndReverseNumbers
{
    using System;
    using System.Collections.Generic;

    public class ReadAndReverseNumbers
    {
        public static void Main()
        {
            var stackOfNumbres = ReadInput();

            Console.Write("The reversed sequence is: ");

            while (stackOfNumbres.Count > 0)
            {
                var currentNumber = stackOfNumbres.Pop();
                Console.Write(currentNumber + " ");
            }

            Console.WriteLine();
        }

        private static Stack<int> ReadInput()
        {
            Console.WriteLine("Please, enter a sequence of numbers:");

            var stackOfNumbres = new Stack<int>();

            while (true)
            {
                var number = 0;
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                if (int.TryParse(input, out number))
                {
                    stackOfNumbres.Push(number);
                }
                else
                {
                    Console.WriteLine("This is not a number!");
                }
            }

            return stackOfNumbres;
        }
    }
}
