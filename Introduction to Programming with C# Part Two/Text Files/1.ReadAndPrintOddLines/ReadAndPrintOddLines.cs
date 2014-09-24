using System;
using System.IO;
using System.Text;

namespace TextFiles
{
    class ReadAndPrintOddLines
    {
        static void Main()
        {
            Encoding encod = Encoding.GetEncoding(1251);
            StreamReader readFile = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\Test.txt", encod);
            using (readFile)
            {
                string line = readFile.ReadLine();
                int count = 0;
                while (line != null)
                {
                    if (count % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    line = readFile.ReadLine();
                    count++;
                }
            }
        }
    }
}
