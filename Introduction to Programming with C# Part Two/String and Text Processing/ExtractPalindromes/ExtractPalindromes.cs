//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;

namespace ExtractPalindromes
{
    class ExtractPalindromes
    {
        static void Main()
        {
            string text = "The band ABBA were very popular in the 70s and 80s.";
            char[] punctuation = new char[]{' ', '.', ',', '!', '?'};
            string[] words = text.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    char[] rev = words[i].ToCharArray();
                    Array.Reverse(rev);
                    if (words[i] == new string(rev))
                    {
                        Console.WriteLine(words[i]);
                    }
                }
            }
        }
    }
}
