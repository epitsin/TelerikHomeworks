//Write a program for extracting all email addresses from given text. 
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

namespace ExtractEmailAddress
{
    class ExtractEmailAddress
    {
        static void Main()
        {
            string text = Console.ReadLine();
            MatchCollection emails = Regex.Matches(text, @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b");
            foreach (var email in emails)
	        {
		        Console.WriteLine(email);
	        }
        }
    }
}
