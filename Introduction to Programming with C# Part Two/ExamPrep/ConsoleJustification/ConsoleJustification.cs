using System;
using System.Text;

namespace ConsoleJustification
{
    class ConsoleJustification
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            StringBuilder wholeText = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                wholeText.Append(Console.ReadLine());
                wholeText.Append(' ');
            }
            string whole = wholeText.ToString();
            char[] separ = new char[]{' '};
            string[] words = whole.Split(separ, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            int j = 0;
            while (j < words.Length)
            {
                StringBuilder current = new StringBuilder();
                current.Append(words[j]);
                if (j < words.Length - 1 && current.Length + 1 + words[j + 1].Length <= m)
                {
                    while (j < words.Length - 1 && current.Length + 1 + words[j + 1].Length <= m)
                    {
                        current.Append(' ');
                        current.Append(words[j + 1]);
                        j++;
                    }
                    int ind = 0;
                    int count = 1;
                    while (current.Length < m)
                    {
                        ReplaceSpaces(ref current, ref ind, ref count);
                    }
                }
                string res = current.ToString();
                res = res.TrimEnd();
                if (j < words.Length - 1)
                {
                    result.AppendLine(res);
                }
                else
                {
                    result.Append(res);
                }
                j++;
            }

            Console.WriteLine(result);
        }

        static void ReplaceSpaces (ref StringBuilder current, ref int firstIndex, ref int count)
        {
            string cur = current.ToString();
            int index = cur.IndexOf(' ', firstIndex);
            string old = new string(' ', count);
            string rep = new string(' ', count + 1);
            current.Replace(old, rep, index, count);
            if (cur.IndexOf(' ', index + count + 1) == -1)
            {
                count += 1;
                firstIndex = 0;
            }
            else
            {
                firstIndex = index + count + 1;
            }
        }
    }
}
