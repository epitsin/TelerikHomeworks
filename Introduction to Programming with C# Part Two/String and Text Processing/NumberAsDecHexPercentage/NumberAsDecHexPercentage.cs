//Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
//percentage and in scientific notation. Format the output aligned right in 15 symbols.

using System;
using System.Globalization;

namespace NumberAsDecHexPercentage
{
    class NumberAsDecHexPercentage
    {
        static void Main()
        {
            int dec = 123;
            Console.WriteLine("{0, 15}", dec.ToString("D", CultureInfo.InvariantCulture));

            int hex = 58;
            Console.WriteLine("{0, 15}", hex.ToString("X", CultureInfo.InvariantCulture));

            double per = 0.95;
            Console.WriteLine("{0, 15}", per.ToString("P2", CultureInfo.InvariantCulture));

            double exp = 123.123456789;
            Console.WriteLine("{0, 15}", exp.ToString("E2", CultureInfo.InvariantCulture)); 

        }
    }
}
