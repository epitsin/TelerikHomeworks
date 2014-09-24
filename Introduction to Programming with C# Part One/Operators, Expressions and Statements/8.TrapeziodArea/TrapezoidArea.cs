using System;

namespace _8.Trapezoid
{
    class TrapezoidArea
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            float area = (float)(a + b) * height / 2;
            Console.WriteLine(area);
        }
    }
}
