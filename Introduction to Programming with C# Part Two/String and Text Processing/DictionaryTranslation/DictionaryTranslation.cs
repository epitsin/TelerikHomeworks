//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. 
//Sample dictionary:
//.NET – platform for applications from Microsoft
//CLR – managed execution environment for .NET
//namespace – hierarchical organization of classes

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace DictionaryTranslation
{
    class DictionaryTranslation
    {
        static void Main()
        {
            string dictionary = ".NET – platform for applications from Microsoft\nCLR – managed execution environment for .NET\nnamespace – hierarchical organization of classes\n";
            List<string[]> words = new List<string[]>();
            char[] separators = new char[] { '–', '\n' };
            string[] w = dictionary.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < w.Length; i+=2)
			{
                string[] current = new string[2];
                current[0] = w[i].Trim();
                current[1] = w[i+1].Trim();
                words.Add(current);
			}

            string input = "namespace";
            for (int i = 0; i < words.Count; i++)
            {
                if (string.Compare(input, words[i][0], true) == 0)
                {
                    Console.WriteLine("{0} -> {1}", input, words[i][1]);
                }
            }

        }
    }
}
