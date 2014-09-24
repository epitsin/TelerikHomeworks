//Write a program that extracts from a given text all sentences containing given word.
//        Example: The word is "in". The text is:

//We are living in a yellow submarine. We don't have anything else. 
//Inside the submarine is very tight. So we are drinking all the day. 
//We will move out of it in 5 days.

//        The expected result is:

//We are living in a yellow submarine.
//We will move out of it in 5 days.

//        Consider that the sentences are separated by "." and the words – by non-letter symbols.

using System;
using System.Text.RegularExpressions;

namespace ExtractSentancesFromText
{
    class ExtractSentancesFromText
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string wanted = @"\bin\b";
            string[] sentences = text.Split('.');
            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, wanted, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("{0}.", sentence.Trim());
                }
            }
        }
    }
}
