using System;

namespace EnglishPronunciation
{

    class EnglishPronunciation
    {

        static void Main()
        {
            Console.WriteLine("Please, enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int digits = number % 10;
            string digit = null;
            switch (digits)
            {
                case 0:
                    digit = ""; break;
                case 1:
                    digit = "one"; break;
                case 2:
                    digit = "two"; break;
                case 3:
                    digit = "three"; break;
                case 4:
                    digit = "four"; break;
                case 5:
                    digit = "five"; break;
                case 6:
                    digit = "six"; break;
                case 7:
                    digit = "seven"; break;
                case 8:
                    digit = "eight"; break;
                case 9:
                    digit = "nine"; break;
            }
            number = number / 10;
            int tens = number % 10;
            string ten = null;
            switch (tens)
            {
                case 0:
                    ten = ""; break;
                case 1:
                    if (digits == 1)
                    {
                        ten = "eleven";
                    }
                    else if (digits == 2)
                    {
                        ten = "twelve";
                    }
                    else if (digits == 3)
                    {
                        ten = "thirteen";
                    }
                    else if (digits == 4)
                    {
                        ten = "fourteen";
                    }
                    else if (digits == 5)
                    {
                        ten = "fifteen";
                    }
                        else if (digits == 6)
                    {
                        ten = "sixteen";
                    }
                        else if (digits == 7)
                    {
                        ten = "seventeen";
                    }
                        else if (digits == 8)
                    {
                        ten = "eighteen";
                    }
                        else if (digits == 9)
                    {
                        ten = "nineteen";
                    }
                        else if (digits == 0)
                    {
                        ten = "ten";
                    }
                    break;
                case 2:
                    ten = "twenty "; break;
                case 3:
                    ten = "thirty "; break;
                case 4:
                    ten = "fourty "; break;
                case 5:
                    ten = "fifty "; break;
                case 6:
                    ten = "sixty "; break;
                case 7:
                    ten = "seventy "; break;
                case 8:
                    ten = "eighty "; break;
                case 9:
                    ten = "ninety "; break;
            }
            number = number / 10;
            int hundred = number % 10;
            string hundreds = null;
            switch (hundred)
            {
                case 0:
                    hundreds = ""; break;
                case 1:
                    hundreds = "one " + "hundred " + "and "; break;
                case 2:
                    hundreds = "two " + "hundred " + "and "; break;
                case 3:
                    hundreds = "three " + "hundred " + "and "; break;
                case 4:
                    hundreds = "four " + "hundred " + "and "; break;
                case 5:
                    hundreds = "five " + "hundred " + "and "; break;
                case 6:
                    hundreds = "six " + "hundred " + "and "; break;
                case 7:
                    hundreds = "seven " + "hundred " + "and "; break;
                case 8:
                    hundreds = "eight " + "hundred " + "and "; break;
                case 9:
                    hundreds = "nine " + "hundred " + "and "; break;
            }
            number = number / 10;
            int thousands = number % 10;
            switch (thousands)
            {
                case 0:
                    Console.Write("" + hundreds + ten + digit); break;
                case 1:
                    Console.Write("one thousand " + hundreds + ten + digit); break;
                case 2:
                    Console.Write("two thousand " + hundreds + ten + digit); break;
                case 3:
                    Console.Write("three thousand " + hundreds + ten + digit); break;
                case 4:
                    Console.Write("four thousand " + hundreds + ten + digit); break;
                case 5:
                    Console.Write("five thousand " + hundreds + ten + digit); break;
                case 6:
                    Console.Write("six thousand " + hundreds + ten + digit); break;
                case 7:
                    Console.Write("seven thousand " + hundreds + ten + digit); break;
                case 8:
                    Console.Write("eight thousand " + hundreds + ten + digit); break;
                case 9:
                    Console.Write("nine thousand " + hundreds + ten + digit); break;
            }
            Console.WriteLine();
        }    
    }
}
