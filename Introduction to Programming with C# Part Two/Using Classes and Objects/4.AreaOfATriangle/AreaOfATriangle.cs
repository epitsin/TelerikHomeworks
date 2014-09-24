using System;

namespace _4.AreaOfATriangle
{
    class AreaOfATriangle
    {
        static double AreaBySideAndAltitude(double a, double hA)
        {
            double area = a * hA / 2;
            return area;
        }

        static double AreaByThreeSides(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return area;
        }

        static double AreaByTwoSidesAndAngle(double a, double b, double angle)
        {
            double area = a * b * Math.Sin((angle * Math.PI) / 180) / 2;
            return area;
        }

        static void Main()
        {
            Console.WriteLine("Please, enter the 3 sides of a triangle: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the altitude to the first side: ");
            double hA = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the angle between a and b: ");
            double angleAB = double.Parse(Console.ReadLine());

            Console.WriteLine(AreaBySideAndAltitude(a, hA));
            Console.WriteLine(AreaByThreeSides(a, b, c));
            Console.WriteLine(AreaByTwoSidesAndAngle(a, b, angleAB));
        }
    }
}
