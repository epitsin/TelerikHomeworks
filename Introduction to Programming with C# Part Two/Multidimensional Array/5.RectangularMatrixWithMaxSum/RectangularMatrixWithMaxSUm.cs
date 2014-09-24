using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.RectangularMatrixWithMaxSum
{
    class RectangularMatrixWithMaxSUm
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please, enter the rows: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter the cols: ");
            //int m = int.Parse(Console.ReadLine());
            //int[,] array = new int[n, m];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        array[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            int[,] array = 
            {
               { 1, 2, 3, 4, 5 },
               { 2, 3, 4, 5, 6 },
               { 3, 4, 5, 6, 30 }
            };

            int maxSum = 0;
            for (int row = 0; row < array.GetLength(0)-2; row++)
            {
                for (int col = 0; col < array.GetLength(1) - 2; col++)
                {
                    int currentSum = 0;
                    for (int wantedRow = row; wantedRow < row + 3; wantedRow++)
                    {
                        for (int wantedCol = col; wantedCol < col + 3; wantedCol++)
                        {
                            currentSum += array[wantedRow, wantedCol];
                        }
                    }
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
