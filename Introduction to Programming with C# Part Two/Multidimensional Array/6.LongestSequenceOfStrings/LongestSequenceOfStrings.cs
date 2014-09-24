using System;

namespace LongestSequenceOfStrings
{
    class LongestSequenceOfStrings
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //string[,] array = new string[n, m];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        array[i, j] = Console.ReadLine();
            //    }
            //}
            string[,] array =
                {
                    { "ha", "asd", "s", "s", "s", "ha" },
                    { "g", "ha", "s", "sa", "s", "ha" },
                    { "s", "g", "s", "s", "s", "ha" },
                    { "s", "s", "s", "s", "s", "ha" },
                    { "hh", "s", "s", "sdf", "ha", "as" },
                    { "s", "s", "s", "s", "ha", "ha" },
                    { "s", "s", "s", "s", "ha", "ha" },
                    { "s", "fa", "s", "s", "ha", "ha" },
                };
            int maxCount = 0;
            int direction = 0;
            string maxString = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int count = 1;
                    string currentString = array[i, j];
                    int currentRow = i;
                    int currentCol = j;
                    do
                    {
                        switch (direction)
                        {
                            case 0: currentRow++; break;
                            case 1: currentCol++; break;
                            case 2: currentRow++; currentCol++; break;
                        }
                        if (currentRow < array.GetLength(0) && currentCol < array.GetLength(1))
                        {
                            if (array[currentRow, currentCol] == currentString)
                            {
                                count++;
                            }
                            else
                            {
                                direction++;
                                if (direction > 2)
                                {
                                    direction = 0;
                                    break;
                                }
                                currentRow = i;
                                currentCol = j;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    while (true);
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxString = currentString;
                    }
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxString + " ");
            }
            Console.WriteLine();
        }
    }
}
