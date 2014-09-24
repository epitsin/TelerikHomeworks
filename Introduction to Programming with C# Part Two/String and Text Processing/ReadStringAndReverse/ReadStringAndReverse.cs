//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample" -> "elpmas".

using System;

namespace ReadStringAndReverse
{
    class ReadStringAndReverse
    {
        static string Reverse(string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Reverse(input));
        }
    }
}
