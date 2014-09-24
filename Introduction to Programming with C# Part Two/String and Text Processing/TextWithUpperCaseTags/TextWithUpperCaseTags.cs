//You are given a text. Write a program that changes the text in all regions surrounded by 
//the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
//--We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//        The expected result:
//--We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Text.RegularExpressions;

namespace TextWithUpperCaseTags
{
    class TextWithUpperCaseTags
    {
        static string UpperCase (string text)
        {
            return text.ToUpper();
        }
        static string Remove (string text)
        {
            if (text.IndexOf('<') == -1)
            {
                return text;
            }
            int startFirst = text.IndexOf('<');
            int finishFirst = text.IndexOf('>', startFirst);
            int startSecond = text.IndexOf('<', finishFirst);
            int finishSecond = text.IndexOf('>', startSecond);
            string oldSubstring = text.Substring(finishFirst + 1, startSecond - finishFirst - 1);
            string subString = UpperCase(oldSubstring);
            string newText = text.Replace(oldSubstring, subString).Remove(startFirst, "<upcase>".Length).Remove(startSecond - "<upcase>".Length, "</upcase>".Length);
            return Remove(newText);
        }
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            Console.WriteLine(Remove(text));
        }
    }
}
