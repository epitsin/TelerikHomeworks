using System;
using System.Collections.Generic;

namespace _8.MultidimensionalArray
{
    class FillAndPrintMatrix1
    {
        static void Main()
        {
            int[,] array = new int[4, 4];
            int number = 1;

            for (int col = 0; col < 4; col++)
            {
                for (int row = 0; row < 4; row++)
                {
                    array[row, col] = number;
                    number += 1;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
