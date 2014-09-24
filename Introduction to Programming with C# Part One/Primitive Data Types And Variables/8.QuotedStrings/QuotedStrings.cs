using System;

namespace _8.QuotedStrings
{
    class QuotedStrings
    {
        static void Main()
        {
            string noQuotations = "The use of quotations causes difficulties."; //The use of quotations causes difficulties.
            string quoted = "The \"use\" of quotations causes difficulties."; //The "use" of quotations causes difficulties.
            string quoted2 = "\"The \"use\" of quotations causes difficulties.\""; //"The "use" of quotations causes difficulties."
            string nonQuoted = @"The ""use"" of quotations causes difficulties."; //The "use" of quotations causes difficulties.
            string nonQuoted2 = @"""The ""use"" of quotations causes difficulties."""; //"The "use" of quotations causes difficulties."
            Console.WriteLine(noQuotations + '\n' + quoted + '\n' + quoted2 + '\n' + nonQuoted + '\n' + nonQuoted2); //Printing with new lines.
        }
    }
}
