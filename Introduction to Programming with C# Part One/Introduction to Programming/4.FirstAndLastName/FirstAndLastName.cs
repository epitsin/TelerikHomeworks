using System;

namespace _4.FirstAndLastName
{
    class FirstAndLastName
    {
        static void Main()
        {
            // Here we enter the name of the person from the keyboard.

            Console.WriteLine("Please, enter your first name.");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please, enter your last name.");
            string lastName = Console.ReadLine();

            // Here we print a message with the name entered from keyboard inside a certain message using {}.
            Console.WriteLine("Hello, {0} {1}!", firstName, lastName);
            Console.WriteLine();
        }
    }
}
