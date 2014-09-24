using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace _12.RemoveListOfWords
{
    class RemoveListOfWords
    {
        static void Main()
        {
            Encoding cyr = Encoding.GetEncoding(1251);
            try
            {
                StreamReader read = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\ListOfWords.txt", cyr);
                StreamReader text = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\StartFinish.txt", cyr);
                StreamWriter write = new StreamWriter("Replaced.txt");

                string listOfwords = read.ReadToEnd();
                string[] list = listOfwords.Split(' ');

                string readLine = text.ReadLine();
                while (readLine != null)
                {
                    for (int i = 0; i < list.Length; i++)
                    {
                        if (Regex.IsMatch(readLine, list[i]))
                        {
                            readLine = Regex.Replace(readLine, list[i], "*");
                        }
                    }
                    write.WriteLine(readLine);
                    readLine = text.ReadLine();
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
