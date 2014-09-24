//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseWordsInSentance
{
    class ReverseWordsInSentance
    {
        static void Main()
        {
            string text = @"C# is not C++, not PHP: and not Delphi?!";
            text += " ";
            char[] punctuation = new char[] { ' ', ',', '.', '!', '?', ':', ';' };
            string[] reverse = text.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in reverse)
            {
                text = text.Replace(word, string.Empty);
            }
            Array.Reverse(reverse);
            StringBuilder newText = new StringBuilder();
            for (int i = 0, j = 0; i < reverse.Length; i++, j++)
            {
                newText.Append(reverse[i]);
                newText.Append(text[j]);
                while(text[j] != ' ')
                {
                    j++;
                    newText.Append(text[j]);
                }
            }
            Console.WriteLine(newText);
        }
    }
}
