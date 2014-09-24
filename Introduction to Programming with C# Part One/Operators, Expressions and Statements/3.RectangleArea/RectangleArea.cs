using System;

namespace _3.RectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the width of the rectangle: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the height of the rectangle: ");
            int height = int.Parse(Console.ReadLine());
            int area = width * height;
            Console.WriteLine("The area of the rectangle is "+ area);
        }
    }
}
