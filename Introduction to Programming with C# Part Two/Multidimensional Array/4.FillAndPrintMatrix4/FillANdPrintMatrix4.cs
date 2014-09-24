using System;

namespace _4.FillAndPrintMatrix4
{
    class FillANdPrintMatrix4
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the rows/cols of the array: ");
            int number = int.Parse(Console.ReadLine());
            int[,] array = new int[number, number];
            int direction = -1;
            int currentRow = 0;
            int currentCol = 0;
            int countTurns = -1;

            for (int i = 1; i <= number*number; i++)
            {
                array[currentRow, currentCol] = i;
                int maxRow = currentRow;
                int maxCol = currentCol;
                bool outOfBound = false;
                switch (direction)
                {
                    case -1: maxRow++; if (maxRow > (number - 1)) outOfBound = true;
                        break;
                    case 0: maxCol++; if (maxCol > (number - 1)) outOfBound = true; 
                        break;
                    case 1: maxRow--; if (maxRow < 0) outOfBound = true; 
                        break;
                    case 2: maxCol--; if (maxCol < 0) outOfBound = true; 
                        break;
                }
                if (outOfBound==true)
                {
                    if (direction == 2)
                    {
                        direction = -1;
                        countTurns++;
                    }
                    else
                    {
                        direction++;
                        countTurns++;
                    }
                    switch (direction)
                    {
                        case -1: currentRow++; break;
                        case 0: currentCol++; break;
                        case 1: currentRow--; break;
                        case 2: currentCol--; break;
                    }
                }
                else
                {
                    if (array[maxRow, maxCol] != 0)
                    {
                        if (direction == 2)
                        {
                            direction = -1;
                            countTurns++;
                        }
                        else
                        {
                            direction++;
                            countTurns++;
                        }
                        switch (direction)
                        {
                            case -1: currentRow++; break;
                            case 0: currentCol++; break;
                            case 1: currentRow--; break;
                            case 2: currentCol--; break;
                        }
                    }
                    else
                    {
                        currentRow = maxRow;
                        currentCol = maxCol;
                    }
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
