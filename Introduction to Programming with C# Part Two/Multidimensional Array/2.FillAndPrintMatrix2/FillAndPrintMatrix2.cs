using System;
using System.Collections.Generic;

namespace _2.FillAndPrintMatrix2
{
    class FillAndPrintMatrix2
    {
        static void Main()
        {
            int[,] array = new int[4, 4];
            int i = 1;
            bool directionDown = true;
            for (int col = 0; col < 4; col++)
            {
                if (directionDown == true)
                {
                    for (int row = 0; row < 4; row++)
                    {
                        array[row, col] = i;
                        i++;
                    }
                    directionDown = false;
                    continue;
                }
                else
                {
                    for (int row = 3; row >=0; row--)
                    {
                        array[row, col] = i;
                        i++;
                    }
                    directionDown = true; 
                    continue;
                }
            }
            for (int k = 0; k < 4; k++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(array[k,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
