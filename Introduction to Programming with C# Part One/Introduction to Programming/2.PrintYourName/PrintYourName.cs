using System;

namespace _2.PrintYourName
{
    class PrintYourName
    {
        static void Main()
        {
            Console.WriteLine("Please, enter your name.");
            string name = Console.ReadLine(); //Here we enter the person's name from the console.
            Console.WriteLine("Hello, {0}!", name); //Printing the name using {} to put it inside a certain message.
            Console.WriteLine();
        }
    }
}
