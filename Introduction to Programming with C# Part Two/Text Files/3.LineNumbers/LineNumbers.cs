using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            Encoding encod = Encoding.GetEncoding(1251);
            StreamReader read = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\Test.txt", encod);
            using (read)
            {
                string readFile = read.ReadLine();
                int lines = 0;
                StreamWriter write = new StreamWriter("TestWithLines.txt", false, encod);
                while (readFile != null)
                {
                    lines++;
                    write.WriteLine("{0} {1}", lines, readFile);
                    readFile = read.ReadLine();
                }
                write.Close();
            }

        }
    }
}
