//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

namespace WordsInAlphabeticalOrder
{
    class WordsInAlphabeticalOrder
    {
        static void Main()
        {
            string text = "apple carrot banana pineapple cherry kiwi orange";
            string[] words = text.Split(' ');
            Array.Sort(words);
            foreach (var word in words)
            {
                Console.Write("{0} ",word);
            }
            Console.WriteLine();
        }
    }
}
