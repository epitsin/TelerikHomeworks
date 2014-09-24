using System;

namespace _9.Fibinachi
{
    class Fibinachi
    {
        static void Main()
        {
            int m = 0;
            int n = 1;
            Console.WriteLine(m);
            Console.WriteLine(n);
            for (int i = 2; i < 100; i++)
            {
                int next = m + n;
                m = n;
                n = next;
                Console.WriteLine(next);
            }
        }
    }
}
