// Write a program that reads a sequence of integers (List<int>) ending with an empty 
// line and sorts them in an increasing order.

namespace SortListInIncreasingOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortListInIncreasingOrder
    {
        public static void Main()
        {
            var listOfNumbres = ReadInput();

            var orderedList = listOfNumbres.OrderBy(x => x).ToList();

            WriteOutput(orderedList);
        }

        private static void WriteOutput(List<int> orderedList)
        {
            Console.Write("The ordered sequence is: ");
            foreach (var number in orderedList)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

        private static List<int> ReadInput()
        {
            Console.WriteLine("Please, enter a sequence of numbers:");

            var listOfNumbres = new List<int>();

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
                    listOfNumbres.Add(number);
                }
                else
                {
                    Console.WriteLine("This is not a number!");
                }
            }

            return listOfNumbres;
        }
    }
}
