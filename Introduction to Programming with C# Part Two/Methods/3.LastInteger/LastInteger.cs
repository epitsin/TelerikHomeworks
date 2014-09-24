﻿using System;

namespace _3.LastInteger
{
    class LastInteger
    {

        static int LastDigit(int number)
        {
            int last = number % 10;
            return last;
        }

        static void EnglishName(int last)
        {
            switch (last)
            {
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                case 0: Console.WriteLine("Zero"); break;

            }
        }

        static void Main()
        {
            Console.WriteLine("Please, enter a number: ");
            int number = int.Parse(Console.ReadLine());
            EnglishName(LastDigit(number));
        }
    }
}