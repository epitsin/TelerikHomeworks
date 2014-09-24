using System;

namespace _8.IntDoubleStringVariable
{
    class IntDoubleStringVariable
    {
        static void Main()
        {
            int intNumber = 0;
            double doubleNumber = 0;
            Console.WriteLine("Please, enter something: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out intNumber))
            {
                intNumber = int.Parse(input);
                intNumber = intNumber + 1;
                Console.WriteLine(intNumber);
            }
            else if (double.TryParse(input, out doubleNumber))
            {
                doubleNumber = double.Parse(input);
                doubleNumber = doubleNumber + 1;
                Console.WriteLine(doubleNumber);
            }
            else
            {
                input= input + "*";
                Console.WriteLine(input);
            }
            
        }
    }
}
