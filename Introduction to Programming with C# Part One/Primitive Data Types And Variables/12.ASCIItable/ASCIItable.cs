using System;

namespace _12.ASCIItable
{
    class ASCIItable
    {
        static void Main()
        {
            for (int i = 0; i < 127; i++)
            {
                char c = (char)i;
                Console.WriteLine(c);
            }
        }
    }
}
