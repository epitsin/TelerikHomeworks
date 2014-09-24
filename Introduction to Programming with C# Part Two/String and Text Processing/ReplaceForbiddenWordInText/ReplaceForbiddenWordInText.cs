//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. Example:

//Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//        Words: "PHP, CLR, Microsoft"
//        The expected result:

//********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

using System;
using System.Text.RegularExpressions;

namespace ReplaceForbiddenWordInText
{
    class ReplaceForbiddenWordInText
    {
        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string wordsList = "PHP, CLR, Microsoft";
            string newText = string.Empty;
            string[] words = wordsList.Split(',');
            foreach (var word in words)
            {
                text = text.Replace(word.Trim(), new string('*', word.Trim().Length));
            }
            Console.WriteLine(text);
        }
    }
}
