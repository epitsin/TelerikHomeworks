using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace _13.TimesAWordIsContained
{
    class TimesAWordIsContained
    {
        static void Main()
        {
            Encoding cyr = Encoding.GetEncoding(1251);
            try
            {
                StreamReader read = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\ListOfWords.txt", cyr);
                StreamReader text = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\StartFinish.txt", cyr);
                StreamWriter write = new StreamWriter("Result.txt");

                string listOfwords = read.ReadToEnd();
                string[] list = listOfwords.Split(' ');


                int[] counts = new int[list.Length];

                string readLine = text.ReadToEnd();
                for (int i = 0; i < list.Length; i++)
                {
                    int count = Regex.Matches(readLine, list[i], RegexOptions.IgnoreCase).Count;
                    counts[i] = count;
                }
                Array.Sort(counts);
                Array.Reverse(counts);
                foreach (var item in counts)
                {
                    write.WriteLine(item);
                }
                read.Close();
                text.Close();
                write.Close();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.IO.PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
