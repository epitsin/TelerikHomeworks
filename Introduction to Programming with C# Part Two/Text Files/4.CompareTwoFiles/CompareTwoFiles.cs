using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompareTwoFiles
{
    class CompareTwoFiles
    {
        static void Main()
        {
            Encoding encod = Encoding.GetEncoding(1251);
            StreamReader readTextOne = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\Test.txt", encod);
            string first = readTextOne.ReadLine();
            StreamReader readTextTwo = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\Test2.txt", encod);
            string second = readTextTwo.ReadLine();

            int countEqual = 0;
            int countDifferent = 0;

            while (first != null)
            {
                if (first == second)
                {
                    countEqual++;
                }
                else
                {
                    countDifferent++;
                }
                first = readTextOne.ReadLine();
                second = readTextTwo.ReadLine();
            }

            readTextOne.Close();
            readTextTwo.Close();
            Console.WriteLine(countEqual);
            Console.WriteLine(countDifferent);
        }
    }
}
