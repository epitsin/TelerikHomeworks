using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Matrix
{
    class Matrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string num = "";
                int col = 0;
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] != ' ')
                    {
                        num += line[j];
                    }
                    else
                    {
                        matrix[i, col] = int.Parse(num);
                        col++;
                        num = "";
                    }
                }
                matrix[i, col] = int.Parse(num);
            }
            int maxSum = int.MinValue;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
            StreamWriter output = new StreamWriter("Output.txt");
            output.WriteLine(maxSum);
            output.Close();
        }
    }
}
