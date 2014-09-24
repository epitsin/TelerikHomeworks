using System;

namespace _9.Methods
{
    class HelloName
    {
        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your name:");
            string name = Console.ReadLine();
            PrintName(name);
        }
    }
}
