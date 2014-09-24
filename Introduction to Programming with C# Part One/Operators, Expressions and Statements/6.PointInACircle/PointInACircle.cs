using System;

namespace _6.PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            Console.WriteLine("Please, enter X coordinate of a number: ");
            int xCoordinate = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter Y coordinate of a number: ");
            int yCoordinate = int.Parse(Console.ReadLine());
            int radius = 5;
            if (xCoordinate * xCoordinate + yCoordinate * yCoordinate <= radius * radius)
            {
                Console.WriteLine("Your point is inside a circle with coordinates (0,5).");
            }
            else
            {
                Console.WriteLine("Your point is outside a circle with coordinates (0,5).");
            }
        }
    }
}
