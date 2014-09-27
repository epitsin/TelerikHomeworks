namespace KnapsackProblem
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int n = 6;
            int m = 10;
            var matrix = new int[n + 1, m + 1];
            var listOfProducts = new List<Tuple<string, int, int>>();
            var usedProducts = new List<Tuple<string, int, int>>();

            listOfProducts.Add(new Tuple<string, int, int>("beer", 3, 2));
            listOfProducts.Add(new Tuple<string, int, int>("vodka", 8, 12));
            listOfProducts.Add(new Tuple<string, int, int>("cheese", 4, 5));
            listOfProducts.Add(new Tuple<string, int, int>("nuts", 1, 4));
            listOfProducts.Add(new Tuple<string, int, int>("ham", 2, 3));
            listOfProducts.Add(new Tuple<string, int, int>("whiskey", 8, 13));
            
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (listOfProducts[i - 1].Item2 <= j)
                    {
                        matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i - 1, j - listOfProducts[i - 1].Item2] + listOfProducts[i - 1].Item3);
                    }
                    else
                    {
                        matrix[i, j] = matrix[i - 1, j];
                    }
                }
            }

            int row = matrix.GetLength(0) - 1;
            int col = matrix.GetLength(1) - 1;
            while (matrix[row, col] != 0)
            {
                if (matrix[row - 1, col - 1] == matrix[row, col])
                {
                    row -= 1;
                    col -= 1;
                    continue;
                }
                else
                {
                    usedProducts.Add(listOfProducts[row - 1]);
                    row -= 1;
                    col -= listOfProducts[row].Item2;
                }
            }

            Console.WriteLine("The best solution is:");
            foreach (var prod in usedProducts)
            {
                Console.WriteLine(prod.Item1 + " " + prod.Item2 + " " + prod.Item3);
            }
            Console.WriteLine("The max cost is: " + matrix[n, m]);
        }
    }
}
