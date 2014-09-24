//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> 
//with corresponding tags [URL=…]…/URL]. 
//Sample HTML fragment:
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. 
//Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
// -->>
//<p>Please visit [URL=http://academy.telerik. com] our site[/URL] to choose a training course. 
//Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

using System;
using System.Text.RegularExpressions;

namespace HTMLDocumentTags
{
    class HTMLDocumentTags
    {
        static void Main()
        {
            string document = @"<p>Please visit <a href=""http://academy.telerik. com""> our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            document = document.Replace(@"<a href=""", "[URL=");
            document = document.Replace(@""">", "]");
            document = document.Replace("</a>", "[/URL]");
            Console.WriteLine(document);
        }
    }
}
