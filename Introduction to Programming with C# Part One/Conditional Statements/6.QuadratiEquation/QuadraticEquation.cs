using System;

namespace _6.QuadratiEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the first 3 numbers: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if (a == 0)
            {
                double x = (-c) / b;
                Console.WriteLine(x);
            }
            else
            {
                if (D < 0)
                {
                    Console.WriteLine("There is no real solution.");
                }
                else if (D == 0)
                {
                    double x0 = (-b) / (2 * a);
                    Console.WriteLine("There is one solution: ");
                    Console.WriteLine(x0);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("There are 2 solutions: ");
                    Console.WriteLine(x1 + ";" + x2);
                }
            }
        }
    }
}
