using System;

namespace _6.QuadraticEquation
{
    class Equation
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter c: ");
            double c = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("There is one solution: x = " + -c/b);
            }
            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("No real solution.");
            }
            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("There are two solutions: x1 = " + x1);
            Console.WriteLine("There are two solutions: x2 = "  + x2);
        }
    }
}
