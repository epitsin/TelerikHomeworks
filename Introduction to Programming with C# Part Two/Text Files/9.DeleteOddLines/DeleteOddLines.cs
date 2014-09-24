using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main()
        {
            Encoding cyr = Encoding.GetEncoding(1251);
            StreamReader read = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\StartFinish.txt", cyr);
            List<string> allText = new List<string>();
            string line = read.ReadLine();
            while (line != null)
            {
                allText.Add(line);
                line = read.ReadLine();
            }
            read.Close();

            StreamWriter write = new StreamWriter(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\StartFinish.txt");
            for (int i = 0; i < allText.Count; i++)
            {
                if (i % 2 == 0)
                {
                    write.WriteLine(allText[i]);
                }
            }
            write.Close();
        }
    }
}
