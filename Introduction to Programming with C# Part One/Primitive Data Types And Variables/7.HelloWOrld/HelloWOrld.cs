using System;

namespace _7.HelloWOrld
{
    class HelloWOrld
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world + "!"; // Creating an object variable that contains the 2 strings.
            string wholeExpression = (string)helloWorld; // Type casting
            Console.WriteLine(wholeExpression);
        }
    }
}
