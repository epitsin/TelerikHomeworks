using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _4.DownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            try
            {
                string path = @"http://www.devbg.org/img/Logo-BASD.jpg";
                string fileName = @"Logo-BASD.jpg";
                WebClient download = new WebClient();
                download.DownloadFile(path, fileName);
                Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, path);
                Console.WriteLine(@"File downloaded at C:\Users\Elena\Documents\Visual Studio 2012\Projects\11.ExceptionHandling\4.DownloadFile\bin\Debug");
            }

            catch (ArgumentNullException ae)
            {
                Console.WriteLine("{0} - {1}", ae.GetType(), ae.Message);
            }

            catch (WebException webEx)
            {
                Console.WriteLine("{0} - {1}", webEx.GetType(), webEx.Message);
            }

            catch (NotSupportedException supEx)
            {
                Console.WriteLine("{0} - {1}", supEx.GetType(), supEx.Message);
            }
        }
    }
}
