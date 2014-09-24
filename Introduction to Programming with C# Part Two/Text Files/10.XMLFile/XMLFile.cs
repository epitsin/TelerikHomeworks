using System;
using System.IO;
using System.Text;

namespace _10.XMLFile
{
    class XMLFile
    {
        static void Main()
        {
            Encoding cyr = Encoding.GetEncoding(1251);
            using (StreamReader read = new StreamReader(@"C:\Users\Elena\Documents\Visual Studio 2012\Projects\TextFiles\XML.xml", cyr))
            {
                using (StreamWriter write = new StreamWriter("XML.txt", false, cyr))
                {
                    string all = read.ReadToEnd();
                    for (int i = 0; i < all.Length; i++)
                    {
                        string text = String.Empty;
                        if (all[i] == '>')
                        {
                            i++;
                            while (i < all.Length && all[i] != '<' && all[i] != '\\')
                            {
                                text += all[i];
                                i++;
                            }
                            if (!String.IsNullOrWhiteSpace(text))
                            {
                                Console.WriteLine(text.Trim());
                            }

                        }
                    }
                }
            }
        }
    }
}
