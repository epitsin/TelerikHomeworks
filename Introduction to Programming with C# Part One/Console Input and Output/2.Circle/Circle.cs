using System;


namespace Circle
{
    class Circle
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the radius of the circle: ");
            double radius = 0;
            while (true)
            {
                string str = Console.ReadLine();
                if ( double.TryParse(str, out radius))
                {
                    break;
                }
            }
            double perimeter = 2* radius* Math.PI;
            double area = radius * radius * Math.PI;
            Console.WriteLine("The perimeter of the circle is: " + perimeter);
            Console.WriteLine("The area of the circle is: " + area);
        }
    }
}
