using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace _11.DeleteWordsWithTest
{
    class DeleteWordsWithTest
    {
        static void Main()
        {
            Encoding cyr = Encoding.GetEncoding(1251);
            using (StreamReader read = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\WordWithTest.txt", cyr))
            {
                using (StreamWriter write = new StreamWriter("Test.txt", false, cyr))
                {
                    string line = read.ReadToEnd();
                    string[] words = line.Split(' ');
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (!Regex.IsMatch(words[i], "test", RegexOptions.IgnoreCase))
                        {
                            words[i] = Regex.Replace(words[i], @"[^A-Za-z0-9-]", string.Empty);
                            Console.WriteLine(words[i]);
                        }
                    }
                }
            }
        }
    }
}
