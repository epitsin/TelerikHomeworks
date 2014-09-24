//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements. 
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//        [protocol] = "http"
//        [server] = "www.devbg.org"
//        [resource] = "/forum/index.php"

using System;
using System.Text.RegularExpressions;

namespace ParseURLAdress
{
    class ParseURLAdress
    {
        static void Main()
        {
            string url = "http://www.devbg.org/forum/index.php";

            int protocolIndex = url.IndexOf(':');
            string protocol = url.Substring(0, protocolIndex);

            int serverStartIndex = url.IndexOf(@"//");
            int serverLastIndex = url.IndexOf(@"/", serverStartIndex + 2);
            int serverLength = serverLastIndex - serverStartIndex - 2;
            string server = url.Substring(serverStartIndex + 2, serverLength);

            string resource = url.Substring(serverLastIndex, url.Length - serverLastIndex);

            Console.WriteLine(protocol);
            Console.WriteLine(server);
            Console.WriteLine(resource);
        }
    }
}
