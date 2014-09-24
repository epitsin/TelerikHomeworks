//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console.

using System;

namespace StringOf20Characters
{
    class StringOf20Characters
    {
        static void Main()
        {
            string input = string.Empty;
            while (true)
	        {
                Console.WriteLine("Please, enter a string of max 20 characters: ");
                input = Console.ReadLine();
	            if (input.Length <= 20)
                {
                    break;
                }
	        }
            if (input.Length < 20)
            {
                Console.WriteLine(input.PadRight(20, '*'));
            }
        }
    }
}
