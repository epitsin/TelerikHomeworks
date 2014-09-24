//Write a program that reads a string from the console and lists all different words 
//in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordsInString
{
    class WordsInString
    {
        static void Main()
        {
            string input = "Insert some text here. Insert some numbers also. ";

            char[] punctuation = new char[] { ' ', ',', '.', '!', '?' };
            string[] words = input.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> allWords = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (allWords.ContainsKey(words[i]))
                {
                    allWords[words[i]]++;
                }
                else
                {
                    allWords.Add(words[i], 1);
                }
            }

            foreach(var word in allWords)
            {
                Console.WriteLine("{0} is found {1} times.", word.Key, word.Value );
            }

        }
    }
}
