//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
//Example:
//    N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;
using System.Linq;

namespace VariationsOfElements
{
    class VariationsOfElements
    {
        static void Main()
        {
            int n = 5;
            int k = 3;

            string alphabet = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                alphabet += i;
            }

            var q = alphabet.Select(x => x.ToString());
            for (int i = 0; i < k - 1; i++)
            {
                q = q.SelectMany(x => alphabet, (x, y) => x + y);
            }

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
