using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Encoding cyr = Encoding.GetEncoding(1251);

        using (StreamReader read = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\StartFinish.txt", cyr))
        using (StreamWriter output = new StreamWriter("Output.txt"))
            for (string line; (line = read.ReadLine()) != null; )

                output.WriteLine(Regex.Replace(line, @"\Start\b", "finish", RegexOptions.IgnoreCase)); // Exercise 8
    }
}