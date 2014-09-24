//Write a program that reads a string from the console and replaces all series of 
//consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Text.RegularExpressions;

namespace SeriesOfIdenticalLetters
{
    class SeriesOfIdenticalLetters
    {
        static void Main()
        {
            string input = "aaaaabbbbbcdddeeeedssaa";
            for (int i = 0; i < input.Length - 1; i++)
            {
                string letter = input[i].ToString();
                int count = 1;
                int j = i;
                while (j < input.Length-1 && input[j] == input[j+1])
                {
                    count++;
                    j++;
                }
                string substring = input.Substring(i, count);
                input = input.Replace(substring, letter);
            }
            Console.WriteLine(input);
        }
    }
}
