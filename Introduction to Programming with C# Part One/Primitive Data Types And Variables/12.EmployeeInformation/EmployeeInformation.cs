using System;

namespace _12.EmployeeInformation
{
    class EmployeeInformation
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the employee's name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please, enter the employee's family name: ");
            string familyName = Console.ReadLine();
            Console.WriteLine("Please, enter the employee's age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please, write \"m\" or \"f\" the employee's gender: ");
            char gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the employee's unique number: ");
            uint uniqueEmployeeNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the employee's ID number: ");
            long IDnumber = long.Parse(Console.ReadLine());
            Console.WriteLine("The information you have typed is respectively: ");
            Console.WriteLine("string");
            Console.WriteLine("string");
            Console.WriteLine("byte");
            Console.WriteLine("char");
            Console.WriteLine("uint");
            Console.WriteLine("long");
        }
    }
}
