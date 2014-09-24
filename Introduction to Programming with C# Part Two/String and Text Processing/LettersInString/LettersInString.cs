//Write a program that reads a string from the console and prints all different 
//letters in the string along with information how many times each letter is found. 

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LettersInString
{
    class LettersInString
    {
        static void Main()
        {
            string input = "Insert some text here.";
            // FIRST METHOD
            char[] punctuation = new char[] {' ', ',', '.', '!', '?'};
            for (int i = 0; i < punctuation.Length; i++)
			{
                input = input.Replace(punctuation[i].ToString(), string.Empty);
			}

            input = input.ToLower();

            int[] found = new int[26];
            for (int i = 0; i < input.Length; i++)
            {
                int index = (int)input[i] - 97;
                found[index]++;
            }

            for (int i = 0; i < found.Length; i++)
            {
                if (found[i] > 0)
                {
                    Console.WriteLine("{0} is found {1} times.", (char)(i + 97), found[i]);
                }  
            }
            Console.WriteLine();

            //SECOND METHOD
            for (int i = 0; i < 26; i++)
            {
                char current = (char)(i + 97);
                int count = Regex.Matches(input, current.ToString(), RegexOptions.IgnoreCase).Count;
                if (count>0)
                {
                    Console.WriteLine("{0} is found {1} times.", current, count);
                }
            }
        }
    }
}
