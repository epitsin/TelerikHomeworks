using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FillAndPrintMatrix3
{
    class FillAndPrintMatrix3
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter the rows/cols of the array: ");
            int number = int.Parse(Console.ReadLine());
            int[,] array = new int[number, number];
            int currentRow = number - 1;
            int currentCol = 0;
            int count = 1;
            for (int i = 1; i <= number*2-1; i++)
            {
                array[currentRow, currentCol] = count;
                count++;
                int maxRow = currentRow + 1;
                int maxCol = currentCol + 1;
                while (maxRow <= number - 1 && maxCol <= number - 1)
                {
                    array[maxRow, maxCol] = count;
                    count++;
                    maxRow++;
                    maxCol++;
                }
                if (currentRow > 0)
                {
                    currentRow--;
                }
                else if (currentRow == 0)
                {
                    currentCol++;
                }
            }

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write("{0,4}", array[row, col]);
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
