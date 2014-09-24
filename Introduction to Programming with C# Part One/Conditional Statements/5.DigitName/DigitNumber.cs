using System;

namespace _5.DigitName
{
    class DigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Please,enter a number: ");
            int digit = 0;
            while (true)
            {
                string str = Console.ReadLine();
                if (int.TryParse(str, out digit))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a number.");
                }
            }

            switch (digit)
            {
                case 1: Console.WriteLine("One"); 
                    break;
                case 2: Console.WriteLine("Two"); 
                    break;
                case 3: Console.WriteLine("Three"); 
                    break;
                case 4: Console.WriteLine("Four"); 
                    break;
                case 5: Console.WriteLine("Five"); 
                    break;
                case 6: Console.WriteLine("Six"); 
                    break;
                case 7: Console.WriteLine("Seven"); 
                    break;
                case 8: Console.WriteLine("Eight"); 
                    break;
                case 9: Console.WriteLine("Nine"); 
                    break;
                case 0: Console.WriteLine("Zero"); 
                    break;
                default: Console.WriteLine("Not a digit."); 
                    break;
            }
        }
    }
}
