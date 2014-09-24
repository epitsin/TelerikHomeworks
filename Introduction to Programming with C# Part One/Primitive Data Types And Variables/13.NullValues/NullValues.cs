using System;

namespace _13.NullValues
{
    class NullValues
    {
        static void Main()
        {
            int? firstVariable = null; //Assigning null values to the variables.
            int? secondVariable = null;
            Console.WriteLine("The numbers with values null."); //Printing the variables without doing anything to them.
            Console.WriteLine(firstVariable);
            Console.WriteLine(secondVariable);
            Console.WriteLine("The numbers with values null + 5."); // Adding 5 to the null variables and printing them.
            Console.WriteLine(firstVariable + 5);
            Console.WriteLine(secondVariable + 5);
        }
    }
}
