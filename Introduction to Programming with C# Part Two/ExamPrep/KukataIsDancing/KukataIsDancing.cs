using System;

namespace KukataIsDancing
{
    class KukataIsDancing
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int[,] field = new int[3, 3];
                int startRow = 1;
                int startCol = 1;
                int direction = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'W')
                    {
                        switch(direction)
                        {
                            case -1: startRow--;
                                break;
                            case 0: startCol++;
                                break;
                            case 1: startRow++;
                                break;
                            case 2: startCol--;
                                break;
                        }
                        if (startRow > 2)
                        {
                            startRow = 0;
                        }
                        else if (startRow < 0)
                        {
                            startRow = 2;
                        }
                        if (startCol > 2)
                        {
                            startCol = 0;
                        }
                        else if (startCol < 0)
                        {
                            startCol = 2;
                        }
                    }
                    else if (input[j] == 'R')
                    {
                        direction++;
                        if (direction > 2)
                        {
                            direction = -1;
                        }
                    }
                    else
                    {
                        direction--;
                        if (direction < -1)
                        {
                            direction = 2;
                        }
                    }
                }
                if((startRow == 0 || startRow == 2) && (startCol == 0 || startCol == 2) )
                {
                    Console.WriteLine("RED");
                }
                else if (startRow == 1 && startCol == 1)
                {
                    Console.WriteLine("GREEN");
                }
                else
                {
                    Console.WriteLine("BLUE");
                }
            }
        }
    }
}
