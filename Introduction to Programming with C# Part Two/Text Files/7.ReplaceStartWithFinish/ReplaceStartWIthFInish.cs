using System;
using System.IO;
using System.Text;

namespace _7.ReplaceStartWithFinish
{
    class ReplaceStartWIthFInish
    {
        static void Main()
        {
            Encoding cyr = Encoding.GetEncoding(1251);
            StreamReader read = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\StartFinish.txt", cyr);
            StreamWriter write = new StreamWriter("Replace.txt");

            string readLine = read.ReadLine();
            while (readLine != null)
            {
                string[] replace = readLine.Split(' ');  // allText = allText.Replace("start", "finish"); !!!!!!!!!
                for (int i = 0; i < replace.Length; i++)
                {
                    if (replace[i] == "Start")
                    {
                        replace[i] = "Finish";
                    }
                    else if (replace[i] == "start")
                    {
                        replace[i] = "finish";
                    }
                    else if (replace[i] == "START")
                    {
                        replace[i] = "FINISH";
                    }
                    write.Write(replace[i] + " ");
                }
                write.WriteLine();
                readLine = read.ReadLine();
            }
            read.Close();
            write.Close();
        }
    }
}
