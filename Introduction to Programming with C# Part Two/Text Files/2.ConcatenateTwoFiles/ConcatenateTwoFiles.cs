using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ConcatenateTwoFiles
{
    class ConcatenateTwoFiles
    {
        static void Main()
        {
            Encoding encod = Encoding.GetEncoding(1251);
            StreamReader readTextOne = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\Test.txt", encod);
            string first = readTextOne.ReadToEnd();
            StreamReader readTextTwo = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\Test2.txt", encod);
            string second = readTextTwo.ReadToEnd();
            StreamWriter concat = new StreamWriter("ConcatenatedText.txt", false, encod);
            using (concat)
            {
                concat.WriteLine(first);
                concat.WriteLine(second);
            }
        }
    }
}
