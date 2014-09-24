using System;

namespace _9.WithinAcircleOutsideARectangle
{
    class WithinACircleOutsideARectangle
    {
        static void Main()
        {
            Console.WriteLine("Please, enter X coordinate of a number: ");
            int xCoordinate = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter Y coordinate of a number: ");
            int yCoordinate = int.Parse(Console.ReadLine());
            int radius = 3;
            bool inCircle = false;
            bool inRectangle = false;
            if (xCoordinate>=1 && xCoordinate<=7 && yCoordinate>=-1 && yCoordinate<=1) // Inside or Outside the rectangle
            {
                inRectangle = true;
            }
            if (xCoordinate>=0 && yCoordinate>=0) //First Quadrant
            {
                xCoordinate-=1;
                yCoordinate-=1;
                if (xCoordinate*xCoordinate + yCoordinate*yCoordinate<=radius*radius)
                {
                    inCircle = true;
                }
            }
            else if (xCoordinate>=0 && yCoordinate<=0) // Fourth Quadrant
            {
                xCoordinate-=1;
                yCoordinate+=1;
                if (xCoordinate*xCoordinate + yCoordinate*yCoordinate<=radius*radius)
                {
                    inCircle = true;
                }
            }
            else if (xCoordinate<=0 && yCoordinate>=0) // Second Quadrant
            {
                xCoordinate+=1;
                yCoordinate-=1;
                if (xCoordinate*xCoordinate + yCoordinate*yCoordinate<=radius*radius)
                {
                    inCircle = true;
                }
            }
            else // Third Quadrant
            {
                xCoordinate+=1;
                yCoordinate+=1;
                if (xCoordinate*xCoordinate + yCoordinate*yCoordinate<=radius*radius)
                {
                    inCircle = true;
                }
            }
            if (inCircle== true && inRectangle== false)
            {
                Console.WriteLine("Your point is inside the circle but outside the rectangle.");
            }
            else
            {
                Console.WriteLine("Your point is NOT inside the circle and outside the rectangle.");
            }
        }
    }
}
