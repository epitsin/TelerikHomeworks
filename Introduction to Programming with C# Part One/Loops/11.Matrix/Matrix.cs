using System;

namespace _11.Matrix
{
    class Matrix
    {
        static void Main()
        {
            Console.WriteLine("Please, enter how big is the matrix: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j =i; j <= (n+i-1); j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
