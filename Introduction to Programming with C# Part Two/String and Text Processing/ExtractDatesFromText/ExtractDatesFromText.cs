//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ExtractDatesFromText
{
    class ExtractDatesFromText
    {
        static void Main()
        {
            string text = Console.ReadLine();
            MatchCollection dates = Regex.Matches(text, @"\b[0-9]{2}.[0-9]{2}.[0-9]{4}\b");
            foreach (var date in dates)
            {
                DateTime current = DateTime.Parse(date.ToString());
                Console.WriteLine(current.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat));
            }
        }
    }
}
