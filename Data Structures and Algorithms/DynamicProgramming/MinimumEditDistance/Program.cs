namespace MinimumEditDistance
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var initial = "developer";
            var wanted = "enveloped";

            var matrix = new double[wanted.Length, initial.Length];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    double left = 0;
                    double upperLeft = 0;
                    double upper = 0;
                    double min = 0;
                    double insertion = 0.8;

                    if(i==0 && j==0)
                    {
                        upperLeft = 0;
                        left = 0;
                        upper = 0;
                        insertion = 1;
                    }
                    else if (i == 0)
                    {
                        upper = (j + 1) * 0.9;
                        upperLeft = j * 0.9;
                        left = matrix[i, j - 1];
                    }
                    else if (j == 0)
                    {
                        left = (i + 1) * 0.8;
                        upperLeft = i * 0.8;
                        upper = matrix[i - 1, j];
                    }
                    else
                    {
                        left = matrix[i, j - 1];
                        upper = matrix[i - 1, j];
                        upperLeft = matrix[i - 1, j - 1];
                    }

                    min = upper;
                    if (upperLeft < min)
                    {
                        min = upperLeft;
                        insertion = 1.0;
                    }
                    if (left < min)
                    {
                        min = left;
                        insertion = 0.9;
                    }

                    if (initial[j] == wanted[i])
                    {
                        matrix[i, j] = min;
                    }
                    else
                    {
                        matrix[i, j] = min + insertion;
                    }
                }
            }

            Console.WriteLine("From '{0}' to '{1}' the cost is {2}", initial, wanted, matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1]);
        }
    }
}
