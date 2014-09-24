using System;

namespace _6.SquareNumber
{
    class SquareNumber
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the number you want to find the square root of.");
            int number = int.Parse(Console.ReadLine()); // Here the person can enter different numbers from the console.

            Console.WriteLine("The square root is: " + Math.Sqrt(number)); // Using Math method to find out the square root.
            Console.WriteLine();
        }
    }
}
