//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

namespace CompareCharArraysLexicographically
{
    class CompareCharArraysLexicographically
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the first word (char array): ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Please, enter the second word (char array): ");
            string input2 = Console.ReadLine();

            int result = string.Compare(input1, input2);
            switch (result)
            {
                case -1: Console.WriteLine("{0} is before {1} lexicographically.", input1, input2);
                    break;
                case 0: Console.WriteLine("{0} and {1} are one and the same word!", input1, input2);
                    break;
                case 1: Console.WriteLine("{0} is before {1} lexicographically.", input2, input1);
                    break;
            }    
        }
    }
}
