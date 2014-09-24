using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ReadAndSOrt
{
    class ReadAndSort
    {
        static void Main()
        {
            Encoding cyr = Encoding.GetEncoding(1251);
            StreamReader read = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\Names.txt", cyr);
            StreamWriter write = new StreamWriter("Sorted.txt");
            List<string> sort = new List<string>();
            string readLine = read.ReadLine();
            while (readLine != null)
            {
                sort.Add(readLine);
                readLine = read.ReadLine();
            }
            read.Close();
            sort.Sort();
            foreach (string value in sort)
            {
                write.WriteLine(value);
            }
            write.Close();
        }
    }
}
