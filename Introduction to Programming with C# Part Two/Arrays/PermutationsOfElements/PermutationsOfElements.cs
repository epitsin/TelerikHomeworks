//* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
//Example:
//    n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

using System;
using System.Linq;

namespace PermutationsOfElements
{
    class PermutationsOfElements
    {
        public static void permuteString(String beginningString, String endingString)
        {
            if (endingString.Length <= 1)
            {
                Console.WriteLine(beginningString + endingString);
            }
            else
            {
                for (int i = 0; i < endingString.Length; i++)
                {
                    String newString = endingString.Substring(0, i);
                    newString += endingString.Substring(i + 1);
                    permuteString(beginningString + endingString.ElementAt(i), newString);
                }
            }
        }

        static void Main()
        {
            permuteString(String.Empty, "123");
        }
    }
}
