// Write a program that reads from the console a sequence of positive integer numbers. 
// The sequence ends when empty line is entered. Calculate and print the sum and average of the elements of the sequence. 
// Keep the sequence in List<int>.

namespace SumAndAverageOfListOfInt
{
    using System;
    using System.Collections.Generic;

    public class SumAndAverageOfList
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter a sequence of numbers:");

            var sumOfNumbers = 0;
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
                    sumOfNumbers += number;
                    listOfNumbres.Add(number);
                }
                else
                {
                    Console.WriteLine("This is not a number!");
                }
            }

            Console.WriteLine("The sum of the numbers is: " + sumOfNumbers);

            var averageOfNumbers = sumOfNumbers / listOfNumbres.Count;
            Console.WriteLine("The average of the numbers is: " + averageOfNumbers);
        }
    }
}
