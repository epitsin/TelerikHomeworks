using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3.EnterReadAndPrintAFIle
{
    class EnterReadAndPrintAFIle
    {
        static void Main()
        {
            try
            {
                //Console.WriteLine("Please, enter the path to the file: ");
                //string path = Console.ReadLine();
                System.Text.Encoding newText = System.Text.Encoding.GetEncoding(1251);
                string path = @"C:\Users\Elena\Downloads\4. Kaspichania Boats.txt";

                // This text is added only once to the file. 
                //if (!File.Exists(path))
                //{
                //    // Create a file to write to. 
                //    string createText = "Hello and Welcome" + Environment.NewLine;
                //    File.WriteAllText(path, createText);
                //}

                //// This text is always added, making the file longer over time 
                //// if it is not deleted. 
                //string appendText = "This is extra text" + Environment.NewLine;
                //File.AppendAllText(path, appendText);
                
                // Open the file to read from. 
                string readText = File.ReadAllText(path,newText);
                File.WriteAllText("ftext.txt", "uehgfrhukrhfkedhfnr");
                Console.WriteLine(readText);
            }

            catch (ArgumentNullException fe)
            {
                Console.WriteLine(fe.Message);
            }

            catch (ArgumentException fe)
            {
                Console.WriteLine(fe.Message);
            }

            catch (PathTooLongException fe)
            {
                Console.WriteLine(fe.Message);
            }

            catch (DirectoryNotFoundException fe)
            {
                Console.WriteLine(fe.Message);
            }

            catch (FileNotFoundException fe)
            {
                Console.WriteLine(fe.Message);
            }

            catch (IOException fe)
            {
                Console.WriteLine(fe.Message);
            }

            catch (UnauthorizedAccessException fe)
            {
                Console.WriteLine(fe.Message);
            }

            catch (NotSupportedException fe)
            {
                Console.WriteLine(fe.Message);
            }

        }
    }
}
